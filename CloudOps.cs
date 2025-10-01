using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace CloudOps.Dotnet.FunctionApp;

public class CloudOps
{
    private readonly ILogger<CloudOps> _logger;

    public CloudOps(ILogger<CloudOps> logger)
    {
        _logger = logger;
    }

    [Function("CloudOps")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Beyond CloudOps!");
    }
}