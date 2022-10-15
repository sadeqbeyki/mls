using MLS.Domain.Entities;
using MLS.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace MLS.WebUI.Models
{
    public abstract class TodoItemViewModel
    {
        [Required]
        [StringLength(50,MinimumLength =3)]
        public string? Title { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string? Note { get; set; }
        public long ListId { get; set; }

        //public PriorityLevel Priority { get; set; }
        //public DateTime? Reminder { get; set; }
    }
    //لیست انتخاب شده که در نهایت ارسال میشود
    public class NewTodoItemViewModel : TodoItemViewModel
    {
        public List<TodoItem>? Items { get; set; }
        public List<TodoList>? Lists { get; set; }
    }
    //در صفحه پست نمایش داده میشود
    public class ViewTodoItemViewModel : TodoItemViewModel
    {
        public List<int>? SelectedList { get; set; }
    }
}
