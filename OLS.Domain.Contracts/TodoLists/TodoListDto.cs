using AppFramework.Domain;
using OLS.Domain.Entities;

namespace OLS.Domain.Contracts.TodoLists;

public class TodoListDto
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ListImage { get; set; }
    public List<TodoItem> Items { get; set; }


}
