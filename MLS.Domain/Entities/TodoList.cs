using AppFramework.Domain;

namespace MLS.Domain.Entities
{
    public class TodoList : BaseEntity
    {
        //public int ListId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<TodoItem>? Items { get; set; }/*private set; } = new List<TodoItem>();*/
    }
}
