using CsuChhs.Turnstile.Clients;

namespace CsuChhs.Turnstile;

public class CloudflareTurnstileClient : ICloudflareTurnstileClient
{

    public CloudflareTurnstileClient()
    {
        Token = new TokenClient();
    }
    
    public ITokenClient Token { get; }
}