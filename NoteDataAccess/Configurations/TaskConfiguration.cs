using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Note.DataAccess;

    public sealed class TaskConfiguration : IEntityTypeConfiguration<MyTask>
    {
        public void Configure(EntityTypeBuilder<MyTask> builder)
        {
            builder
            .HasKey(t => t.Id)
            .HasName("pk_id");

            builder
            .Property(c => c.Id)
            .HasColumnType("SERIAL")
            .HasColumnName("id")
            .IsRequired();

            builder
            .Property( t => t.Title)
            .HasColumnName("title")
            .HasColumnType("VARCHAR(50)")
            .IsRequired();

            builder
            .Property(t => t.Description)
            .HasColumnName("description");

            builder
            .Property(t => t.Status)
            .HasColumnName("status");

            // builder
            // .Property(t => t.Category)
            // .HasColumnName("category");

            // builder
            // .Property(t => t.CategoryId)
            // .HasColumnName("category_id");

            // builder
            // .Property(t => t.UserId)
            // .HasColumnName("user_id");

            // builder
            // .HasOne(t => t.User)
            // .WithMany(t => t.tasks)
            // .HasForeignKey(c => c.UserId);

            //  builder
            //  .HasOne(t => t.Category)
            //  .WithMany(c => c.tasks);
        }
    }
