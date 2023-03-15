using System.ComponentModel.DataAnnotations;

namespace MLS.WebUI.Models.TodoListModel;

public class UpdateTodoListDto:CreateTodoListDto
{
    public long? Id { get; set; }

}
