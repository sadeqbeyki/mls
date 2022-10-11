using AppFramework.Domain;
using MLS.Domain.Enums;

namespace MLS.Domain.Entities
{
    public class TodoItem : BaseEntity
    {
        public string? Title { get; set; }

        public string? Note { get; set; }

        public PriorityLevel Priority { get; set; }

        public DateTime? Reminder { get; set; }
        public TodoList List { get; set; } = null!;
    }
}
