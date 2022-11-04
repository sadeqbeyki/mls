namespace MLS.Application.TodoLists
{
    public class TodoListViewModel
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        
        public string? Description { get; set; }
        public string ListImage { get; set; }
    }

    //public class DisplayTodoListViewModel : TodoListViewModel
    //{
    //    public List<TodoItem>? Items { get; set; }
    //}
    //public class ViewTodoListViewModel : TodoListViewModel
    //{
    //    public List<int>? ListItems { get; set; }
    //}
}
