using Microsoft.AspNetCore.Mvc;

namespace ProgramRiskApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RisksController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(new[] { "Risk API is working" });
    }
}