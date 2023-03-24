using OLS.Domain.Contracts.TodoLists;

namespace OLS.Domain.Contracts.TodoLists;

public class UpdateTodoList : TodoListDto
{
    public long Id { get; set; }
}