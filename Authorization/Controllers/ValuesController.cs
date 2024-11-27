using Authorization.Attributes;
using DataAccess.Context;
using DataAccess.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Authorization.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    AppDbContext context = new();

    [HttpGet("[action]")]
    public async Task<IActionResult> Get(string userName, CancellationToken cancellationToken)
    {
        User? user = await context.Users.Where(p => p.UserName == userName).FirstOrDefaultAsync(cancellationToken);

        string token = JwtProvider.CreateToken(user);
        return Ok(new { Token = token });
    }

    [HttpGet("[action]")]
    [Authorize(AuthenticationSchemes = "Bearer", Roles = "GetAll")]
    public IActionResult GetAll()
    {
        IList<string> strings = new List<string>();
        for (int i = 0; i < 10; i++)
        {
            strings.Add(i + ". Name");
        }

        return Ok(strings);
    }

    //[Role("Admin")]
    [RoleFilter("Admin")]
    [HttpGet("[action]")]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public IActionResult GetAllAdminRole()
    {
        IList<string> strings = new List<string>();
        for (int i = 0; i < 10; i++)
        {
            strings.Add(i + ". Name");
        }

        return Ok(strings);
    }
}
