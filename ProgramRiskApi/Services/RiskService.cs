using ProgramRiskApi.Models;

namespace ProgramRiskApi.Services;

public class RiskService
{
    private readonly List<Risk> _items = new()
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
        }
    };

    public List<Risk> GetAll()
    {
        return _items.Where(x => !x.IsDeleted).ToList();
    }
}