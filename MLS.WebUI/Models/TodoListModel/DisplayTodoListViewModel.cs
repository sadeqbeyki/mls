using MLS.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace MLS.WebUI.Models.TodoListModel
{
    public class DisplayTodoListViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string? Title { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string? Description { get; set; }
        public List<TodoItem>? Items { get; set; }
    }
}
