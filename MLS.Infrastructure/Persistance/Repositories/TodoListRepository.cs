using AppFramework.Infrastructure;
using MLS.Application.TodoLists;
using MLS.Domain.Entities;
using MLS.Infrastructure.Persistance;

namespace MLS.Infrastructure.Repositories
{
    public class TodoListRepository : BaseRepository<long, TodoList>, ITodoListRepository
    {
        public TodoListRepository(TodoContext dbContext) : base(dbContext)
        {
        }
    }
}
