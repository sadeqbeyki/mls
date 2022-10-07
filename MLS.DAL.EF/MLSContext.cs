using Microsoft.EntityFrameworkCore;
using MLS.Core.Entities;
using MLS.DAL.EF.Mapping;

namespace MLS.DAL.EF
{
    public class MLSContext : DbContext
    {
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }

        public MLSContext(DbContextOptions<MLSContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(ProductCategoryMapping).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
