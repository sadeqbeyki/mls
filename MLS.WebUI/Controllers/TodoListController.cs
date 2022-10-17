using Microsoft.AspNetCore.Mvc;
using MLS.Application.TodoItems;
using MLS.Application.TodoLists;
using MLS.Domain.Entities;
using MLS.WebUI.Models;

namespace MLS.WebUI.Controllers;

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

    #region Create TodoList
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(ViewTodoListViewModel model)
    {
        //if valid
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

        //if not valid
        DisplayTodoListViewModel getTodoList = new()
        {
            Title = model.Title,
            Description = model.Description,
            Items = _todoItemRepository.GetAll().ToList()
        };
        return View(getTodoList);

    }
    #endregion

    #region Read TodoList
    public IActionResult Details(int id)
    {
        var items = _todoItemRepository.GetAll().ToList();
        var itemsList = items.Where(x => x.ListId == id).ToList();
        return View(itemsList);

    }
    #endregion

    #region Update TodoList
    [HttpGet]
    public PartialViewResult Update(long id)
    {
        var list = _todoListRepository.Get(id);
        return PartialView("Update", list);
    }
    [HttpPost]
    public IActionResult Update(TodoList model)
    {
        if (ModelState.IsValid)
        {
            _todoListRepository.Update(model);
            return RedirectToAction("Index");
        }
        return new JsonResult(model);
    }
    #endregion

    #region Delete TodoList
    public IActionResult Delete(int id)
    {
        _todoListRepository.Delete(id);
        return RedirectToAction("Index");
    }
    #endregion
}

