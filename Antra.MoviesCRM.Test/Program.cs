using System.Text.Json;
using System.Text.Json.Serialization;
using Antra.MoviesCRM.Core.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

var host = new HostBuilder()
    .ConfigureServices(services =>
    {
        services.AddHttpClient();
        services.AddTransient<MoviesService>();
    })
    .Build();

try
{
    var movieService = host.Services.GetRequiredService<MoviesService>();
    var gitHubBranches = await movieService.GetMovies();

    Console.WriteLine($"{gitHubBranches?.Count() ?? 0} GitHub Branches");

    if (gitHubBranches is not null)
    {
        foreach (var gitHubBranch in gitHubBranches)
        {
            Console.WriteLine($"- {gitHubBranch.Title}");
        }
    }
}
catch (Exception ex)
{
    host.Services.GetRequiredService<ILogger<Program>>()
        .LogError(ex, "Unable to load");
}

public class MoviesService
{
    private readonly IHttpClientFactory _httpClientFactory;

    public MoviesService(IHttpClientFactory httpClientFactory) =>
        _httpClientFactory = httpClientFactory;

    public async Task<IEnumerable<MovieModel>?> GetMovies()
    {
        var httpRequestMessage = new HttpRequestMessage(
            HttpMethod.Get,
            "https://rmorishimamovieshop.azurewebsites.net/api/Movies") //using deployed server
        {
            Headers =
            {
                { "Accept", "application/json" },
                { "User-Agent", "MoviesTestApp" }
            }
        };

        var httpClient = _httpClientFactory.CreateClient();
        var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);

        httpResponseMessage.EnsureSuccessStatusCode();

        using var contentStream =
            await httpResponseMessage.Content.ReadAsStreamAsync();

        return await JsonSerializer.DeserializeAsync
            <IEnumerable<MovieModel>>(contentStream);
    }
}