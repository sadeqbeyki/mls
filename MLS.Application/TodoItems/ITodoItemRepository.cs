using AppFramework.Application;
using MLS.Domain.Entities;

namespace MLS.Application.TodoItems
{
    public interface ITodoItemRepository : IBaseRepository<long, TodoItem>
    {

    }
}