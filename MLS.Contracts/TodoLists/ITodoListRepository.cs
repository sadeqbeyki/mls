using AppFramework.Application;
using MLS.Domain.Entities;

namespace MLS.Contracts.TodoLists
{
    public interface ITodoListRepository : IBaseRepository<long, TodoList>
    {

    }
}
