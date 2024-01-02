using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Note.DataAccess;

public sealed class NoteDbContext : DbContext
{
    private static string _DeafultConnectionString = "DefaultConnection";
    IConfiguration _configuration;
    
     public NoteDbContext(DbContextOptions<NoteDbContext> options, IConfiguration configuration) : base(options)
     {
        _configuration = configuration;
     }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString(_DeafultConnectionString));
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
