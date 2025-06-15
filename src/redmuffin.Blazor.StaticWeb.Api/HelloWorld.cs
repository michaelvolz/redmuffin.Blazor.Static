using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

#pragma warning disable CA1848
#pragma warning disable IDE0290

namespace redmuffin.Blazor.StaticWeb.Api;

public class HelloWorld
{
	private readonly ILogger<HelloWorld> _logger;

	public HelloWorld(ILogger<HelloWorld> logger)
	{
		_logger = logger;
	}

	[Function("HelloWorld")]
	public IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
	{
		_logger.LogInformation("C# HTTP trigger function processed a request.");
		return new OkObjectResult("Welcome to Azure Functions!");
	}
}