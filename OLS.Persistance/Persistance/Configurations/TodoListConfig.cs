using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MLS.Domain.Entities;

namespace OLS.Persistance.Persistance.Configurations
{
    public class TodoListConfig : IEntityTypeConfiguration<TodoList>
    {
        public void Configure(EntityTypeBuilder<TodoList> builder)
        {
            builder.ToTable("TodoLists");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(500).IsRequired();

            builder.HasMany(x => x.Items)
                .WithOne(x => x.ListName)
                .HasForeignKey(x => x.ListId);
        }
    }
}
