namespace Domain.Entities;

public class Stadium
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? City { get; set; }
    public int Capacity { get; set; }
}