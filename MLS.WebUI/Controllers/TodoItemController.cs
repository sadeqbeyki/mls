using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.Language;
using MLS.Application.TodoItems;
using MLS.Application.TodoLists;
using MLS.Domain.Entities;
using MLS.WebUI.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MLS.WebUI.Controllers;

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

    #region Add TodoItem
    public IActionResult Add()
    {
        DisplayTodoItemViewModel newModel = new()
        {
            TodoLists = _todoListRepository.GetAll().ToList(),
        };
        return View(newModel);
    }
    [HttpPost]
    public IActionResult Add(ViewTodoItemViewModel model)
    {
        if (ModelState.IsValid)
        {
            TodoItem todoItem = new()
            {
                Title = model.Title,
                Note = model.Note,
                ListId = model.ListId,
            };
            _todoItemRepository.Add(todoItem);
            return RedirectToAction("Index");
        }

        DisplayTodoItemViewModel displayTodoItem = new()
        {
            Title = model?.Title,
            Note = model?.Note,

            TodoLists = _todoListRepository.GetAll().ToList()
        };
        return View(displayTodoItem);
    }
    #endregion

    #region Update TodoItem
    [HttpGet]
    public IActionResult Update(long id)
    {
        var item = _todoItemRepository.GetDetails(id);
        item.TodoLists = _todoListRepository.GetAll().ToList();
        return PartialView("Update", item);
    }
    [HttpPost]
    public IActionResult Update(UpdateTodoItem model)
    {
        if (ModelState.IsValid)
        {
            _todoItemRepository.Edit(model);
            return new JsonResult(model);
        }
        return RedirectToAction("Index");
    }
    #endregion

    #region Delete TodoItem
    public IActionResult Delete(int id)
    {
        _todoItemRepository.Delete(id);
        return RedirectToAction("Index");
    }
    #endregion

}
