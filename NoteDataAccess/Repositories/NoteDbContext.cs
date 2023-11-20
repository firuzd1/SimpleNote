using Microsoft.EntityFrameworkCore;


namespace Note.DataAccess;

public sealed class NoteDbContext : DbContext
{
    
     public NoteDbContext(DbContextOptions<NoteDbContext> options) : base(options)
     {

     }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(DatabaseHelper.ConnectionString);
        }
    }

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
