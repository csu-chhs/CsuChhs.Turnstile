using CsuChhs.Turnstile.ResourceModels;

namespace CsuChhs.Turnstile.Clients;

public interface ITokenClient
{
    /// <summary>
    /// Validates a Cloudflare Turnstile token.
    /// </summary>
    /// <param name="resourceModel"></param>
    /// <param name="token"></param>
    /// <returns></returns>
    Task<TokenValidationResponseResourceModel?> ValidateAsync(TokenValidationRequestResourceModel resourceModel,
        CancellationToken token = default(CancellationToken));
}