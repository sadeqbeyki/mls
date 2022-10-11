using AppFramework.Infrastructure;
using MLS.Contracts.TodoLists;
using MLS.Domain.Entities;

namespace MLS.Infrastructure.Repositories
{
    public class TodoListRepository : BaseRepository<long, TodoList>, ITodoListRepository
    {
        public TodoListRepository(TodoContext dbContext) : base(dbContext)
        {
        }
    }
}
