﻿using MLS.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace MLS.WebUI.Models
{
    public abstract class TodoListViewModel
    {
        [Required]
        [StringLength(50,MinimumLength =3)]
        public string? Title { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string? Description { get; set; }
    }

    public class PostTodoListViewModel : TodoListViewModel
    {

    }
    public class GetTodoListViewModel : TodoListViewModel
    {
        public IList<TodoItem> Items { get; set; } = new List<TodoItem>();
    }
}