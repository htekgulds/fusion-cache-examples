namespace FusionCacheExamples.Api.Services;

public class CachedService(ILogger<CachedService> logger)
{
    public async Task<string> GetCachedResult()
    {
        logger.LogInformation("Caching result...");
        await Task.Delay(1000);

        return "Hello World";
    }
}