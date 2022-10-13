using Microsoft.AspNetCore.Mvc;
using MLS.Contracts.TodoItems;
using MLS.Contracts.TodoLists;
using MLS.Domain.Entities;
using MLS.WebUI.Models;

namespace MLS.WebUI.Controllers
{
    public class TodoListController : Controller
    {
        private readonly ITodoListRepository _todoListRepository;
        private readonly ITodoItemRepository _todoItemRepository;

        public TodoListController(ITodoListRepository todoListRepository, ITodoItemRepository todoItemRepository)
        {
            _todoListRepository = todoListRepository;
            _todoItemRepository = todoItemRepository;
        }

        public IActionResult Index()
        {
            var todoList = _todoListRepository.GetAll().ToList();
            return View(todoList);
        }
        public IActionResult Add()
        {
            CreateTodoListViewModel model = new()
            {
                Items = _todoItemRepository.GetAll().ToList()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(CreateTodoListViewModel model)
        {
            if (ModelState.IsValid)
            {
                TodoList postTodoList = new()
                {
                    Title = model.Title,
                    Description = model.Description,

                };
                _todoListRepository.Add(postTodoList);
                return RedirectToAction("Index");
            }

            ViewTodoListViewModel getTodoList = new()
            {
                Title = model.Title,
                Description = model.Description,
                ListItems = _todoItemRepository.GetAll().ToList()
            };
            return View(getTodoList);
        }
    }
}
