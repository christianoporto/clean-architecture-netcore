using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace CleanArchitectureApp.Api.Functions
{
    public class FunctionExample
    {
        private readonly ILogger<FunctionExample> _logger;

        public FunctionExample(ILogger<FunctionExample> logger)
        {
            _logger = logger;
        }

        [Function("FunctionExample")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
