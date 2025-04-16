using CsuChhs.Turnstile.ResourceModels;
using Microsoft.Extensions.Logging;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;

namespace CsuChhs.Turnstile.Clients;

public class TokenClient : ITokenClient
{
    private const string Url = "https://challenges.cloudflare.com/turnstile/v0/siteverify";

    private RestClient _BuildClient()
    {
        var options = new RestClientOptions(Url)
        {
        };

        return new RestClient(options,
            configureSerialization: s => s.UseNewtonsoftJson());
    }

    /// <inheritdoc/>
    public async Task<TokenValidationResponseResourceModel?> ValidateAsync(TokenValidationRequestResourceModel resourceModel,
         CancellationToken token = default)
    {
        RestClient client = _BuildClient();
        var request = new RestRequest();
        request.AddJsonBody(resourceModel);
        var response = await client.ExecuteAsync<TokenValidationResponseResourceModel>(request, Method.Post, token);

        if(response.IsSuccessful)
        {
            return response.Data;
        }

        var ex = new InvalidOperationException("Failed to validate cloudflare token",
            response.ErrorException);
        ex.Data.Add("Response", response.Content);
        throw ex;
    }
}