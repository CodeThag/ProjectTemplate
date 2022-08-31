using Application.Common.Mappings;
using Domain.Entities;
using Domain.Enums;

namespace Application.Common.Dtos;

public class TodoItemDto : IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Title { get; set; }

    public string? Note { get; set; }

    public PriorityLevel Priority { get; set; }

    public DateTime? Reminder { get; set; }

    public bool Done { get; set; }
}
