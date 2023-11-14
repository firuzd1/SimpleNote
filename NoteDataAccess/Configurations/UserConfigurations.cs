using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Note.DataAccess;

    public sealed class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
            .HasKey(u => u.Id)
            .HasName("pk_id");

            builder
            .Property(u => u.Id)
            .UseIdentityAlwaysColumn()
            .HasColumnName("id")
            .IsRequired();

            builder
            .Property(u => u.FirstName)
            .HasColumnName("first_name")
            .HasColumnType("VARCHAR(20)")
            .IsRequired();

            builder
            .Property(u => u.LastName)
            .HasColumnName("last_name")
            .HasColumnType("VARCHAR(20)")
            .IsRequired();

            builder
            .Property(u => u.Email)
            .HasColumnName("email")
            .HasColumnType("VARCHAR(20)")
            .IsRequired();

            builder
            .Property(u => u.Password)
            .HasColumnName("phone")
            .HasColumnType("VARCHAR(20)")
            .IsRequired();

            builder
            .HasMany(u => u.tasks)
            .WithOne(t => t.User)
            .HasForeignKey(t => t.UserId);
        }
    }
