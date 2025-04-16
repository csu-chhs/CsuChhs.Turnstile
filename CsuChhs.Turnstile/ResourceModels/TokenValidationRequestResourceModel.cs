namespace CsuChhs.Turnstile.ResourceModels;

public class TokenValidationRequestResourceModel
{
    public TokenValidationRequestResourceModel()
    {
        Secret = string.Empty;
        Response = string.Empty;
    }
    
    public string Secret { get; set; }
    public string Response { get; set; }
    public string? RemoteIp { get; set; }
    public string? Idempotency_Key { get; set; }
}