using AppFramework.Application;
using MLS.Domain.Entities;

namespace MLS.Application.TodoLists
{
    public interface ITodoListRepository : IBaseRepository<long, TodoList>
    {
        List<TodoListViewModel> GetTodoLists();
    }
}
