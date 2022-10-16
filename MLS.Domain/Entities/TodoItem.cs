using AppFramework.Domain;

namespace MLS.Domain.Entities
{
    public class TodoItem : BaseEntity
    {
        public string? Title { get; set; }
        public string? Note { get; set; }
        public long ListId { get; set; }
        public TodoList? ListName { get; set; }

        //public PriorityLevel Priority { get; set; }
        //public DateTime? Reminder { get; set; }
    }
}
