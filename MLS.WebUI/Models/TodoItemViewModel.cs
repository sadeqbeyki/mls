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
        //public PriorityLevel Priority { get; set; }
        //public DateTime? Reminder { get; set; }
    }

    public class CreateTodoItemViewModel : TodoItemViewModel
    {
        public TodoList? List { get; set; }
    }
    public class ViewTodoItemViewModel : TodoItemViewModel
    {
        public List<TodoList>? Lists { get; set; }
    }
}
