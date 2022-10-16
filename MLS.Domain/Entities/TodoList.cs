using AppFramework.Domain;

namespace MLS.Domain.Entities
{
    public class TodoList : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<TodoItem>? Items { get; set; }

    }
}
