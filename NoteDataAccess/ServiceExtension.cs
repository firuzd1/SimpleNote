using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Note.DataAccess;

public static class ServiceExtension
{
    public static void ConfigureDataAccess(this IServiceCollection services)
    {
        services.AddDbContext<NoteDbContext>(

        
            opt => opt.UseNpgsql("Server=localhost;Port=5432;User ID=postgres;Password=12345;Database=SimpleNote")
      );


        
        // services.AddDbContext<NoteDbContext>(
        //     opt => opt.UseNpgsql(DatabaseHelper.ConnectionString));

        services.AddScoped<IUserRepository, EfCoreUserRepository>();
        services.AddScoped<ITaskRepository, EfCoreTaskRepository>();
        services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
    }
}