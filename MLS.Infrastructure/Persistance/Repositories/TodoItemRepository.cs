
using AppFramework.Infrastructure;
using MLS.Application.TodoItems;
using MLS.Domain.Entities;
using MLS.Infrastructure.Persistance;

namespace MLS.Infrastructure.Repositories
{
    public class TodoItemRepository : BaseRepository<long, TodoItem>, ITodoItemRepository
    {
        public TodoItemRepository(TodoContext dbContext) : base(dbContext)
        {
        }
    }
}