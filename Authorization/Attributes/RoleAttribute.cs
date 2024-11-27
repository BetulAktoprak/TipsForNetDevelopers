using Authorization.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace Authorization.Attributes;

public sealed class RoleAttribute : Attribute, IAuthorizationFilter
{
    private readonly string _role;
    private readonly IRoleService _roleService;

    public RoleAttribute(string role, IRoleService roleService)
    {
        _role = role;
        _roleService = roleService;
    }
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        //AppDbContext appDbContext = new();

        var userIdClaim = context.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier);
        if (userIdClaim is null)
        {
            context.Result = new UnauthorizedResult();
            return;
        }

        var userHasRole = _roleService.UserHasRole(userIdClaim.Value, _role);

        //var userHasRole = appDbContext.UserRoles
        //    .Where(p => p.UserId == int.Parse(userIdClaim.Value))
        //    .Include(p => p.Role)
        //    .Any(p => p.Role.Name == _role);
        if (!userHasRole)
        {
            context.Result = new UnauthorizedResult();
            return;
        }
    }
}
