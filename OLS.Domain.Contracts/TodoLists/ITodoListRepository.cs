using AppFramework.Application;

namespace OLS.Domain.Contracts.TodoLists;

public interface ITodoListRepository : IBaseRepository<long, TodoListDto>
{
}