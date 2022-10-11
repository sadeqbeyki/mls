using Framework.Core;
using MLS.Domain.Entities;

namespace MLS.Contracts.Interfaces.TodoItems
{
    public interface ITodoItemRepository : IBaseRepository<long, TodoItem>
    {

    }
}