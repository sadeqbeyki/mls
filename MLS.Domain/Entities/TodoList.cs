using AppFramework.Domain;

namespace MLS.Domain.Entities
{
    public class TodoList : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
    }
}
