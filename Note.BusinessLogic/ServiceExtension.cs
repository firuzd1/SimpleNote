using Note.DataAccess;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
namespace BusinessLogic;

public static class ServiceExtension
{
    public static void ConfigureSimpleNoteServices(this IServiceCollection services)
    {
        services.ConfigureDataAccess();
        services.AddTransient<IUserService, UserService>();
        services.AddTransient<ITaskService, TaskService>();
        services.AddTransient<ICategoryService, CategoryService>();
    }
}