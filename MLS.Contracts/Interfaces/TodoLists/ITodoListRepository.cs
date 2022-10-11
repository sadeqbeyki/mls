using Framework.Core;
using MLS.Core.Entities;

namespace MLS.Contracts.Interfaces.TodoLists
{
    public interface ITodoListRepository : IBaseRepository<long, TodoList>
    {

    }
}
