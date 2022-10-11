﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MLS.Contracts.TodoItems;
using MLS.Contracts.TodoLists;
using MLS.Infrastructure.Repositories;

namespace MLS.Infrastructure
{
    public class ConfigureServices
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddScoped<ITodoListRepository, TodoListRepository>();
            services.AddScoped<ITodoItemRepository, TodoItemRepository>();

            services.AddDbContext<TodoContext>(x => x.UseSqlServer(connectionString));
        }
    }
}