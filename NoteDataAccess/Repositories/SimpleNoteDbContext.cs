using Microsoft.EntityFrameworkCore;


namespace DataAccess;

public sealed class SimpleNoteDbContext : DbContext
{
    public SimpleNoteDbContext(DbContextOptions<SimpleNoteDbContext> options)
        :base(options)
    {}
    public DbSet<User> users { get; set; }
    public DbSet<MyTask> tasks { get; set;}
    public DbSet<Category> categories { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new TaskConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
    }
}