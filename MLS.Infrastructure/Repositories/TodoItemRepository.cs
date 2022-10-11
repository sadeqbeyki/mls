
using AppFramework.Infrastructure;
using MLS.Contracts.TodoItems;
using MLS.Domain.Entities;

namespace MLS.Infrastructure.Repositories
{
    public class TodoItemRepository : BaseRepository<long, TodoItem>, ITodoItemRepository
    {
        public TodoItemRepository(TodoContext dbContext) : base(dbContext)
        {
        }
    }
}