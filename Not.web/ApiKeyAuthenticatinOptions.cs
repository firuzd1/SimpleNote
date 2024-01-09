using Microsoft.AspNetCore.Authentication;

namespace Note.Web;

public sealed class ApiKeyAuthenticationOptions : AuthenticationSchemeOptions
{
    public const string ApiKeyScheme = "ApiKeyScheme";
    public string? ApiKey { get; set; }
}