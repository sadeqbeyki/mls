
using AppFramework.Domain;

namespace OLS.Domain.Entities;

public class TodoItem : BaseEntity
{
    public string? Title { get; set; }
    public string? Note { get; set; }
    public long ListId { get; set; }
    public TodoList ListName { get; set; }
 

    public void Edit(string? title, string? note, long listId)
    {
        Title = title;

        Note = note;

        ListId = listId;
    }
}
