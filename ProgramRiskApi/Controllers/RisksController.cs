using Microsoft.AspNetCore.Mvc;
using ProgramRiskApi.Models;
using ProgramRiskApi.Services;

namespace ProgramRiskApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RisksController : ControllerBase
{
    private readonly RiskService _service;

    public RisksController(RiskService service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_service.GetAll());
    }
}