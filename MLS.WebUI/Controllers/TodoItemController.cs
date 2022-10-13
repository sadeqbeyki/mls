using Microsoft.AspNetCore.Mvc;
using MLS.Contracts.TodoItems;
using MLS.Contracts.TodoLists;
using MLS.Domain.Entities;
using MLS.WebUI.Models;

namespace MLS.WebUI.Controllers
{
    public class TodoItemController : Controller
    {
        private readonly ITodoListRepository _todoListRepository;
        private readonly ITodoItemRepository _todoItemRepository;

        public TodoItemController(ITodoItemRepository todoItemRepository, ITodoListRepository todoListRepository)
        {
            _todoItemRepository = todoItemRepository;
            _todoListRepository = todoListRepository;
        }

        public IActionResult Index()
        {
            var todoItems = _todoItemRepository.GetAll().ToList();
            return View(todoItems);
        }

        public IActionResult Add()
        {
            
            var todoLists = _todoListRepository.GetAll().ToList();
            return View(todoLists);
        }
        [HttpPost]
        public IActionResult Add(CreateTodoItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                TodoItem todoItem = new()
                {
                    Title = model.Title,
                    Note = model.Note,
                    //List = new List<TodoList>(model.List(i => new TodoList
                    //{
                    //    ItemId = i.Id,
                    //}).ToList())
                };
                _todoItemRepository.Add(todoItem);
                return RedirectToAction("Index");
            }
            ViewTodoItemViewModel viewTodoItem = new()
            {
                Title = model?.Title,
                Note = model?.Note,

                Lists = _todoListRepository.GetAll().ToList(),
            };

            return View(viewTodoItem);
        }
    }
}
