using AppFramework.Application;
using OLS.Domain.Entities;

namespace OLS.Domain.Contracts.TodoItems;

public interface ITodoItemRepository : IBaseRepository<long, TodoItem>
{
    OperationResult Add(TodoItem item);
    UpdateTodoItem GetDetails(long id);
    OperationResult Edit(UpdateTodoItem todoItem);
    TodoItem GetItemWithList(long id);
}