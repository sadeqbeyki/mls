﻿using Microsoft.AspNetCore.Mvc;
using MLS.Application.TodoItems;
using MLS.Application.TodoLists;
using MLS.Domain.Entities;
using MLS.WebUI.Models.TodoItemModel;
using MLS.WebUI.Models.TodoListModel;

namespace MLS.WebUI.Controllers;

public class TodoListController : Controller
{
    private readonly ITodoListRepository _todoListRepository;
    private readonly ITodoItemRepository _todoItemRepository;
    private readonly IWebHostEnvironment _webHostEnvironment;

    public TodoListController(ITodoListRepository todoListRepository, ITodoItemRepository todoItemRepository, IWebHostEnvironment webHostEnvironment)
    {
        _todoListRepository = todoListRepository;
        _todoItemRepository = todoItemRepository;
        _webHostEnvironment = webHostEnvironment;
    }

    public IActionResult Index()
    {
        var todoList = _todoListRepository.GetAll().ToList();
        return View(todoList);
    }

    #region Create TodoList
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(CreateTodoListViewModel model)
    {
        string stringFileName = UploadFile(model);
        if (ModelState.IsValid)
        {
            TodoList todoList = new()
            {
                Title = model.Title,
                Description = model.Description,
                ListImage = stringFileName
            };
            _todoListRepository.Create(todoList);
            return RedirectToAction("Index");
        }
        return View(model);

    }

    private string UploadFile(CreateTodoListViewModel model)
    {
        string fileName = string.Empty;
        if (model.ListImage != null)
        {
            string uploadDir = Path.Combine(_webHostEnvironment.WebRootPath, "Images");
            fileName = Guid.NewGuid().ToString() + "-" + model.ListImage.FileName;
            string filePath = Path.Combine(uploadDir, fileName);
            using(var fileStream = new FileStream(filePath, FileMode.Create))
            {
                model.ListImage.CopyTo(fileStream);
            }
        }
        return fileName;
    }
    #endregion

    #region Read TodoList
    public IActionResult Details(int id)
    {
        var items = _todoItemRepository.GetAll().ToList();
        if (items != null)
        {
            var itemsList = items.Where(x => x.ListId == id).ToList();
            return View(itemsList);

        }
        //if (itemsList.Count > 0)
        //{
        //    List<ViewTodoItemViewModel> model = new()
        //    {
        //        ListId = id,
        //        Id = itemsList.ToList().First().Id,
        //        Title = itemsList.ToList().First().Title,
        //        CreationDate = itemsList.ToList().First().CreationDate.ToString(),
        //        Note = itemsList.ToList().First().Note
        //    };
        //    return View(model);
        //}
        return NotFound();
    }
    #endregion

    #region Update TodoList
    [HttpGet]
    public IActionResult Update(long id)
    {
        var todoList = _todoListRepository.Get(id);
        if (todoList != null)
        {
            UpdateTodoListViewModel model = new()
            {
                Id = id,
                Title = todoList.Title,
                Description = todoList.Description
            };
            return View(model);
        }
        return NotFound();
    }
    [HttpPost]
    public IActionResult Update(long id, UpdateTodoListViewModel model)
    {
        if (ModelState.IsValid)
        {
            var todoList = _todoListRepository.Get(id);
            if (todoList != null)
            {
                todoList.Title = model.Title;
                todoList.Description = model.Description;

                _todoListRepository.Update(todoList);
            }
            return RedirectToAction("Index");
        }
        return View(model);
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

