namespace ProgramRiskApi.Models;

public class Risk
{
    public int Id { get; set; }

    public string Title { get; set; } = "";

    public string Description { get; set; } = "";

    public int Probability { get; set; }

    public int Impact { get; set; }

    public int RiskScore { get; set; }

    public string RiskLevel { get; set; } = "";

    public bool IsMitigated { get; set; } = false;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public bool IsDeleted { get; set; } = false;
}