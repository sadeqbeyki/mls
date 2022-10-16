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
        public IActionResult Details()
        {

            var items = _todoItemRepository.GetAll().ToList();
            TodoList todoList = new();
            var itemList = new List<TodoItem>();
            foreach (var item in items)
            {
                if (item.ListId == todoList.Id)
                {
                    ViewTodoListViewModel model = new();
                }
            }
            return View();
            //DisplayTodoListViewModel model = new()
            //{
            //    Items = _todoItemRepository.GetAll().ToList()
            //};
            //return View(model);

        }
        public IActionResult Add()
        {
            return View();
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

            //DisplayTodoListViewModel getTodoList = new()
            //{
            //    Title = model.Title,
            //    Description = model.Description,
            //    Items = _todoItemRepository.GetAll().ToList()
            //};
            //return View(getTodoList);
            return View();
        }
    }
}
