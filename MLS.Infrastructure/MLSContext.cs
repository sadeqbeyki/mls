using Microsoft.EntityFrameworkCore;
using MLS.Core.Entities;
using MLS.Domain.Entities;
using MLS.Infrastructure.Configurations;

namespace MLS.Infrastructure
{
    public class MLSContext : DbContext
    {
        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<TodoItem> TodoItems { get; set; }

        public MLSContext(DbContextOptions<MLSContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var assembly = typeof(TodoListConfiguration).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
