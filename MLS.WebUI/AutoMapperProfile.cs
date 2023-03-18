using AutoMapper;
using MLS.WebUI.Models.TodoItemModel;
using OLS.Domain.Entities;

namespace MLS.WebUI;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<TodoItem, TodoItemDto>();
    }
}