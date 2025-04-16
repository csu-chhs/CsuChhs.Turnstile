// See https://aka.ms/new-console-template for more information

using CsuChhs.Turnstile;
using CsuChhs.Turnstile.ResourceModels;

TokenValidationRequestResourceModel tokenRequest = new();
tokenRequest.Secret = "2x0000000000000000000000000000000AA";
tokenRequest.Response = "XXXX.DUMMY.TOKEN.XXXX";

ICloudflareTurnstileClient client = new CloudflareTurnstileClient();
var response = await client.Token.ValidateAsync(tokenRequest);

Console.WriteLine(response.AsConsoleString());