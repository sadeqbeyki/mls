using AppFramework.Domain;
using System.Xml.Linq;

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

        public void Edit(string? title, string? note, long listId)
        {
            Title = title;

            Note = note;

            ListId = listId;
        }
    }
}
