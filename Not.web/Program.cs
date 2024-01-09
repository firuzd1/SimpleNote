using Note.Web;
using BusinessLogic;
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection(Constants.ConnectionStringsSectionName));
builder.Services.Configure<ApiKeyAuthenticationOptions>(builder.Configuration.GetSection(Constants.ApiKeySectionName));

builder.Services.AddHttpContextAccessor();
builder.Services.ConfigureSimpleNoteServices(builder.Configuration);
builder.Services.AddAuthentication
    (ApiKeyAuthenticationOptions.ApiKeyScheme)
        .AddScheme<ApiKeyAuthenticationOptions, ApiKeyAuthenticationHandler>(ApiKeyAuthenticationOptions.ApiKeyScheme,
            options => { });
            
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.MapControllers();
app.Run();
