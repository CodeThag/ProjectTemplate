using Application.Common.Mappings;
using Domain.Entities;
using Domain.ValueObjects;

namespace Application.Common.Dtos;

public class TodoListDto : IMapFrom<TodoList>
{
    public int Id { get; set; }

    public string Title { get; set; } = string.Empty;

    public Colour Colour { get; set; } = Colour.White;
}
