using AppFramework.Infrastructure;
using MLS.Application.TodoLists;
using MLS.Domain.Entities;
using MLS.Infrastructure.Persistance;

namespace MLS.Infrastructure.Repositories
{
    public class TodoListRepository : BaseRepository<long, TodoList>, ITodoListRepository
    {
        //public TodoListRepository(TodoContext dbContext) : base(dbContext)
        //{
        //}
        private readonly TodoContext _context;

        public TodoListRepository(TodoContext context) : base(context)
        {
            _context = context;
        }

        public List<TodoListViewModel> GetTodoLists()
        {
            return _context.TodoLists.Select(x => new TodoListViewModel
            {
                Id = x.Id,
                Title = x.Title
            }).ToList();
        }
    }
}
