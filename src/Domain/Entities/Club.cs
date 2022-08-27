namespace Domain.Entities;

public class Club
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Founded { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Website { get; set; }
    public Stadium? Stadium { get; set; }
}
