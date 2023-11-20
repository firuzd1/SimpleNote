using Microsoft.AspNetCore.Authentication;

namespace Note.Web;

public sealed class ApiKeyAuthenticationOptions : AuthenticationSchemeOptions
{
    public const string ApiKeyScheme = "ApiKeyScheme";
    public readonly string ApiKey = "hdeX+atb0kS3xfTvVt3XkA==";
}