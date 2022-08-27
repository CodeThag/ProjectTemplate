using Application.Common.Models;
using Domain.Entities;
using Domain.ValueObjects;
using MediatR;

namespace Application.ToDos;

public class GetTodos
{
    public class Query : IRequest<Result<List<TodoList>>> { }

    public class Handler : IRequestHandler<Query, Result<List<TodoList>>>
    {
        public async Task<Result<List<TodoList>>> Handle(Query request, CancellationToken cancellationToken)
        {
            var list = new List<TodoList>
            {
                new TodoList{
                    Colour = Colour.Blue,
                    Id = 1,
                    Title = "Some name"
                }
            };

            return Result<List<TodoList>>.Success(list);
        }
    }
}
