using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MLS.Application.TodoItems;
using MLS.Application.TodoLists;
using MLS.Infrastructure.Persistance;
using MLS.Infrastructure.Persistance.Repositories;
using OLS.Persistance.Persistance.Repositories;

namespace OLS.Persistance;

public class ConfigureServices
{
    public static void Configure(IServiceCollection services, string connectionString)
    {
        services.AddScoped<ITodoListRepository, TodoListRepository>();
        services.AddScoped<ITodoItemRepository, TodoItemRepository>();

        services.AddDbContext<TodoContext>(x => x.UseSqlServer(connectionString));
    }
}