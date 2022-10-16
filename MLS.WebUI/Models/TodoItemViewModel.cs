using MLS.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace MLS.WebUI.Models
{
    public abstract class TodoItemViewModel
    {
        public long ListId { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3)]
        public string? Title { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string? Note { get; set; }
    }
    //لیست انتخاب شده که در نهایت ارسال میشود
    public class DisplayTodoItemViewModel : TodoItemViewModel
    {
        public List<TodoList>? TodoLists { get; set; }
    }
    //در صفحه پست نمایش داده میشود
    public class ViewTodoItemViewModel : TodoItemViewModel
    {
        //public List<int>? SelectedList { get; set; }
    }
}
