using Microsoft.AspNetCore.Mvc;
using MLS.Application.TodoItems;
using MLS.Application.TodoLists;
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
            ViewTodoListViewModel model = new()
            {
                Items = _todoItemRepository.GetAll().ToList()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(ViewTodoListViewModel model)
        {
            if (ModelState.IsValid)
            {
                TodoList addTodoList = new()
                {
                    Title = model.Title,
                    Description = model.Description,

                };
                _todoListRepository.Add(addTodoList);
                return RedirectToAction("Index");
            }

            NewTodoListViewModel getTodoList = new()
            {
                Title = model.Title,
                Description = model.Description,
                ListItems = _todoItemRepository.GetAll().ToList()
            };
            return View(getTodoList);
        }
    }
}
