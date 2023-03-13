using Microsoft.Extensions.DependencyInjection;
using OLS.Persistance.Persistance.Repositories;
using OLS.Domain.Contracts.TodoLists;
using OLS.Domain.Contracts.TodoItems;
using OLS.Persistance.Persistance;
using Microsoft.EntityFrameworkCore;

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