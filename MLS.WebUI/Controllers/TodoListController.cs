using Microsoft.AspNetCore.Mvc;
using MLS.Contracts.TodoLists;
using MLS.Domain.Entities;
using MLS.WebUI.Models;

namespace MLS.WebUI.Controllers
{
    public class TodoListController : Controller
    {
        private readonly ITodoListRepository _todoListRepository;

        public TodoListController(ITodoListRepository todoListRepository)
        {
            _todoListRepository = todoListRepository;
        }

        public IActionResult Index()
        {
            var todoLists = _todoListRepository.GetAll();
            return View(todoLists);
        }
        public IActionResult Add()
        {
            PostTodoListViewModel model = new();
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(PostTodoListViewModel model)
        {
            if (ModelState.IsValid)
            {
                TodoList todoList = new()
                {
                    Title = model.Title,
                    Description = model.Description
                };
                _todoListRepository.Add(todoList);
                return RedirectToAction("Index");
            }
            GetTodoListViewModel getTodoList = new()
            {
                Title = model.Title,
                Description = model.Description
            };
            return View(getTodoList);
        }
    }
}
