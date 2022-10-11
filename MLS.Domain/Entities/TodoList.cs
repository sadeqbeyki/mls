using Framework.Core;
using MLS.Domain.Entities;

namespace MLS.Core.Entities
{
    public class TodoList : EntityBase
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
    }
}
