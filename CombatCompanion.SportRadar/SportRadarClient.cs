using CombatCompanion.SportRadar.Models;
using Microsoft.Extensions.Configuration;
using RestSharp;

namespace CombatCompanion.SportRadar;

public class SportRadarClient
{
    private readonly string _apiKey, _baseUrl;
    private readonly RestClient _client;

    public SportRadarClient(IConfiguration configuration, RestClient client)
    {
        _apiKey = configuration["SportRadarApiKey"];
        _baseUrl = configuration["SportRadarBaseUrl"];
        _client = client;
    }
    
    private async Task<Root<T>> Get<T>(string route)
    {
        try
        {
            var request = new RestRequest($"{_baseUrl}/{route}?api_key={_apiKey}");
            var response = await _client.ExecuteAsync<Root<T>>(request);
            return response.IsSuccessful ? response.Data : null;
        }
        catch
        {
            return null;
        }
    }
}