using AppFramework.Application;
using MLS.Domain.Entities;

namespace OLS.Domain.Contracts.TodoLists;

public interface ITodoListRepository : IBaseRepository<long, TodoList>
{
}