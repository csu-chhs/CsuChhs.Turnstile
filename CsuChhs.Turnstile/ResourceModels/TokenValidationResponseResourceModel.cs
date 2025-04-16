namespace CsuChhs.Turnstile.ResourceModels;

public class TokenValidationResponseResourceModel
{
    public TokenValidationResponseResourceModel()
    {
        Hostname = string.Empty;
        Error_Codes = new();
    }
    
    public bool Success { get; set; }
    public DateTime Challenge_Ts { get; set; }
    public string Hostname { get; set; }
    public List<string> Error_Codes { get; set; }
    public string? Action { get; set; }
    public string? Cdata { get; set; }

    public string AsConsoleString()
    {
        return
            $"Success: {Success}, Challenge_Ts: {Challenge_Ts}, " +
            $"Hostname: {Hostname}, " +
            $"Error_Codes: {string.Join(", ", Error_Codes)}, " +
            $"Action: {Action}, Cdata: {Cdata}";
    }
}