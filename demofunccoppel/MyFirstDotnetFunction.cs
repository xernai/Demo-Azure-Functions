using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace My.Function;

public class MyFirstDotnetFunction
{
    private readonly ILogger<MyFirstDotnetFunction> _logger;

    public MyFirstDotnetFunction(ILogger<MyFirstDotnetFunction> logger)
    {
        _logger = logger;
    }

    [Function("MyFirstDotnetFunction")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}