namespace Domain.Entities;
public class ClubPlayer
{
    public virtual Club Club { get; set; } = new();
    public virtual Player Player { get; set; } = new Player();
    public DateTime Joined { get; set; }
    public DateTime Left { get; set; }
    public int ContractDuration { get; set; }
    public bool IsLoaned { get; set; }
    public Guid LoanedFromId { get; set; }
    public virtual Club? LoanedFrom { get; set; }
}