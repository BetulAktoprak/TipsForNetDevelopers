﻿using Microsoft.AspNetCore.Mvc;
using Record.DTOs;

namespace Record.Controllers;
[Route("api/[controller]")]
[ApiController]
public sealed class ValuesController : ControllerBase
{
    [HttpPost("[action]")]
    public IActionResult LoginWithRecord(Login login)
    {
        return Ok("Giriş başarılı");
    }
}
