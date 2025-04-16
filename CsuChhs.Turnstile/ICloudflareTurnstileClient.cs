using CsuChhs.Turnstile.Clients;

namespace CsuChhs.Turnstile;

public interface ICloudflareTurnstileClient
{
    ITokenClient Token { get; }
}