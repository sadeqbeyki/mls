using AppFramework.Application;
using MLS.Domain.Entities;

namespace MLS.Contracts.TodoItems
{
    public interface ITodoItemRepository : IBaseRepository<long, TodoItem>
    {

    }
}