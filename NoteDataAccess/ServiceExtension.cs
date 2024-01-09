using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Note.DataAccess;

public static class ServiceExtension
{
    private static string _DefaultConnectionkeyName = "DefaultConnection";
    public static void ConfigureDataAccess(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<NoteDbContext>(
            opt => opt.UseNpgsql(configuration.GetConnectionString(_DefaultConnectionkeyName))
      );

        services.AddScoped<IUserRepository, EfCoreUserRepository>();
        services.AddScoped<ITaskRepository, EfCoreTaskRepository>();
        services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
    }
}