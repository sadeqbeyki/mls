
namespace OLS.Domain.Contracts.TodoItems;

public class AddTodoItem
{
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string Title { get; set; }
    [Required]
    [StringLength(500, MinimumLength = 3)]
    public string Note { get; set; }
    public long ListId { get; set; }
    public List<TodoList> TodoLists { get; set; }
}
