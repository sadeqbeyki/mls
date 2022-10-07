using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MLS.Core.ApplicationServices;
using MLS.Core.Contracts;
using MLS.DAL.EF;
using MLS.DAL.EF.Repositories;

namespace MLS.DAL.Configuration
{
    public class MLSBootstrapper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddSingleton<IProductCategoryRepository, EFProductCategoryRepository>();
            services.AddSingleton<ProductCategoryService, ProductCategoryService>();

            services.AddSqlServer<MLSContext>(x => x.UseSqlServer(connectionString));
        }
    }
}