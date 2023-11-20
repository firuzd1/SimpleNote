using System.Security.Claims;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;

namespace Note.Web;

public sealed class ApiKeyAuthenticationHandler : AuthenticationHandler<ApiKeyAuthenticationOptions>
{
    private readonly ApiKeyAuthenticationOptions _apiKeyOptions;

    public ApiKeyAuthenticationHandler(
        IOptionsMonitor<ApiKeyAuthenticationOptions> optionsMonitor,
        ILoggerFactory loggerFactory,
        UrlEncoder encoder,
        ISystemClock clock)
        : base(optionsMonitor, loggerFactory, encoder, clock)
    {
        _apiKeyOptions = optionsMonitor.CurrentValue;
    }

    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        if (!Request.Headers.ContainsKey(Constants.ApiKeyName))
            return AuthenticateResult.Fail($"{Constants.ApiKeyName} not provided in request headers!");

        string? providedApiKey = Request.Headers[Constants.ApiKeyName];
        if (string.IsNullOrEmpty(providedApiKey) || !providedApiKey.Equals(_apiKeyOptions.ApiKey))
            return AuthenticateResult.Fail($"{Constants.ApiKeyName} not valid!");

        return AuthenticateResult.Success(new(GetUserClaims(), Scheme.Name));
    }

    private ClaimsPrincipal GetUserClaims()
    {
        Claim[] claims = new[] { new Claim("AuthenticatedAt", DateTime.Now.ToString()) };
        ClaimsIdentity claimsIdentity = new(claims, Scheme.Name);
        return new(claimsIdentity);
    }
}