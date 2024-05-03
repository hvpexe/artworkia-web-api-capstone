using Application.Models;
using Application.Services.Abstractions;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Nest;

namespace Application.Services.ELK;

public static class ElasticSearchExtensions
{
    public static void AddElasticSearch(
        this IServiceCollection services, IConfiguration configuration)
    {

        string uri = configuration["ELKConfiguration:Uri"] ?? default!;
        string defaultIndex = configuration["ELKConfiguration:Index"] ?? default!;
        string username = configuration["ELKConfiguration:Username"] ?? default!;
        string password = configuration["ELKConfiguration:Password"] ?? default!;

        var setting = new ConnectionSettings(new Uri(uri))
            .BasicAuthentication(username, password)
            .DefaultIndex(defaultIndex)
            .EnableDebugMode()
            .EnableApiVersioningHeader();

        AddDefaultMappings(setting);
        var client = new ElasticClient(setting);
        services.AddSingleton<IElasticClient>(client);

        CreateIndex(client, defaultIndex);
    }

    public static IApplicationBuilder UseInitDataElasticSearch(this IApplicationBuilder app, ILogger logger)
    {
        using var scope = app.ApplicationServices.CreateScope();
        var services = scope.ServiceProvider;
        var artworkService = services.GetRequiredService<IArtworkService>();
        var client = services.GetRequiredService<IElasticClient>();

        if (client.Ping().IsValid)
        {
            logger.LogInformation("ElasticSearch is connected.");
            var artworks = artworkService.GetAllArtworksAsync().Result;

            var bulkIndexResponse = client.Bulk(b => b
                .Index("artworksv2")
                .IndexMany(artworks)
            );
        }
        else
        {
            logger.LogWarning("ElasticSearch is not connected.");
        }

        return app;
    }

    private static void AddDefaultMappings(ConnectionSettings settings)
    {
        //settings.DefaultMappingFor<ArtworksV2>(x => x.Ignore(x => x.IsAIGenerated));
    }

    private static void CreateIndex(IElasticClient client, string indexName)
    {
        var result = client.Indices.Exists(indexName);
        if (!result.Exists)
        {
            client.Indices.Create(Indices.Index(indexName), c => c
                .Map<ArtworksV2>(m => m
                    .AutoMap()
                )
            );
        }
    }
}
