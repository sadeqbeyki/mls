using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MLS.Contracts.Interfaces.TodoLists;
using MLS.Infrastructure.Repositories;
using MLS.Contracts.Interfaces.TodoItems;

namespace MLS.Infrastructure
{
    public class MLSConfigureServices
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddScoped<ITodoListRepository, EFTodoListRepository>();
            services.AddScoped<ITodoItemRepository, EFTodoItemRepository>();
            services.AddScoped<TaskCategoryService, TaskCategoryService>();

            services.AddDbContext<MLSContext>(x => x.UseSqlServer(connectionString));
        }
    }
}