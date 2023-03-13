using AppFramework.Infrastructure;
using OLS.Domain.Contracts.TodoLists;
using OLS.Domain.Entities;

namespace OLS.Persistance.Persistance.Repositories;

public class TodoListRepository : BaseRepository<long, TodoList>, ITodoListRepository
{
    public TodoListRepository(TodoContext dbContext) : base(dbContext)
    {
    }

}
