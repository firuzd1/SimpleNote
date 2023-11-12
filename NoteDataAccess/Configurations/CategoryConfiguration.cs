using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess;


public sealed class SimpleNoteDbContext
{
    public sealed class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
            .HasKey(c => c.Id)
            .HasName("pk_id");

            builder
            .Property(c => c.Id)
            .HasColumnType("SERIAL")
            .HasColumnName("id")
            .IsRequired();

            builder
            .Property(c => c.Name)
            .HasColumnName("name")
            .HasColumnType("VARCHAR(150)");

            builder
            .HasMany(c => c.tasks)
            .WithOne(t => t.Category)
            .HasForeignKey(t => t.CategoryId);
        }
    }
}