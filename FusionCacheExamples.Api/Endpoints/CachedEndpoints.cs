using FusionCacheExamples.Api.Services;
using ZiggyCreatures.Caching.Fusion;

namespace FusionCacheExamples.Api.Endpoints;

public static class CachedEndpoints
{
    public static void MapCachedEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/cached/default", async (IFusionCache cache, CachedService service) =>
        {
            var result = await cache.GetOrSetAsync(
                "default",
                _ => service.GetCachedResult(),
                TimeSpan.FromSeconds(10));
            return Results.Ok(result);
        });
    }
}
public interface ICachedEndpointsLogger;