using AppFramework.Application;
using OLS.Domain.Entities;

namespace OLS.Domain.Contracts.TodoItems;

public interface ITodoItemRepository : IBaseRepository<long, TodoItem>
{
    UpdateTodoItem GetDetails(long id);
    OperationResult Edit(UpdateTodoItem todoItem);
    TodoItem GetItemWithList(long id);
}