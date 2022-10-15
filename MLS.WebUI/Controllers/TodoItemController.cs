using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MLS.Application.TodoItems;
using MLS.Application.TodoLists;
using MLS.Domain.Entities;
using MLS.WebUI.Models;

namespace MLS.WebUI.Controllers
{
    public class TodoItemController : Controller
    {
        private readonly ITodoListRepository _todoListRepository;
        private readonly ITodoItemRepository _todoItemRepository;
        public SelectList TodoLists;

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
            TodoLists = new SelectList(_todoListRepository.GetAll(), "Id", "Title");
            var todoLists = _todoListRepository.GetAll().ToList();
            return View(todoLists);
        }
        [HttpPost]
        public IActionResult Add(ViewTodoItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                TodoItem viewTodoItem = new()
                {
                    Title = model.Title,
                    Note = model.Note,
                    ListId = model.ListId,
                };
                _todoItemRepository.Add(viewTodoItem);
                return RedirectToAction("Index");
            }
            NewTodoItemViewModel newTodoItem = new()
            {
                Title = model?.Title,
                Note = model?.Note,

            };

            return View(newTodoItem);
        }
    }
}
