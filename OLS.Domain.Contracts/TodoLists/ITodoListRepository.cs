using AppFramework.Application;
using OLS.Domain.Entities;

namespace OLS.Domain.Contracts.TodoLists;

public interface ITodoListRepository : IBaseRepository<long, TodoList>
{
}