using Framework.Core;

namespace MLS.Core.Entities
{
    public class TaskCategory : EntityBase
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<Task>? Tasks { get; set; }

        public TaskCategory()
        {
            Tasks = new List<Task>();
        }

        public TaskCategory(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
