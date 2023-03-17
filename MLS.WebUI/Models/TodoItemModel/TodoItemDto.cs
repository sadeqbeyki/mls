using OLS.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace MLS.WebUI.Models.TodoItemModel;

public abstract class TodoItemDto
{
    public long ListId { get; set; }
    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string? Title { get; set; }
    [Required]
    [StringLength(500, MinimumLength = 3)]
    public string? Note { get; set; }
}
//لیست انتخاب شده که در نهایت ارسال میشود
public class DisplayTodoItemDto : TodoItemDto
{
    public List<TodoList>? TodoLists { get; set; }
}
//در صفحه پست نمایش داده میشود
public class ViewTodoItemDto : TodoItemDto
{
    public long Id { get; set; }
    public string CreationDate { get; set; }
}