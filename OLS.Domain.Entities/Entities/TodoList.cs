using AppFramework.Domain;


namespace OLS.Domain.Entities;

public class TodoList : BaseEntity
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ListImage { get; set; }
    public List<TodoItem> Items { get; set; }


}
