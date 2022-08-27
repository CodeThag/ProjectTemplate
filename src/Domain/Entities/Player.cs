namespace Domain.Entities;

public class Player
{
    public Guid Id { get; set; }
    public string? Firstname { get; set; }
    public string? Surname { get; set; }
    public string? Othernames { get; set; }
    public string? PictureUrl { get; set; }
}
