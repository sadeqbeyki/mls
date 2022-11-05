using AppFramework.Infrastructure;
using MLS.Application.TodoLists;
using MLS.Domain.Entities;

namespace MLS.Infrastructure.Persistance.Repositories;

public class TodoListRepository : BaseRepository<long, TodoList>, ITodoListRepository
{
    public TodoListRepository(TodoContext dbContext) : base(dbContext)
    {
    }

}
