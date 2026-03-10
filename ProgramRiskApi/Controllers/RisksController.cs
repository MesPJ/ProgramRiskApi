using Microsoft.AspNetCore.Mvc;
using ProgramRiskApi.Models;

namespace ProgramRiskApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RisksController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(new[] 
        { 
            new Risk 
            { 
                Id = 1, 
                Title = "Risk 1", 
                Description = "Description of Risk 1", 
                Probability = 3, 
                Impact = 4, 
                RiskScore = 12, 
                RiskLevel = "High", 
                IsMitigated = false, 
                CreatedAt = DateTime.UtcNow, 
                UpdatedAt = DateTime.UtcNow, 
                IsDeleted = false 
            },
            new Risk 
            { 
                Id = 2, 
                Title = "Risk 2", 
                Description = "Description of Risk 2", 
                Probability = 2, 
                Impact = 5, 
                RiskScore = 10, 
                RiskLevel = "Medium", 
                IsMitigated = true, 
                CreatedAt = DateTime.UtcNow, 
                UpdatedAt = DateTime.UtcNow, 
                IsDeleted = false 
            }
        });
    }
}