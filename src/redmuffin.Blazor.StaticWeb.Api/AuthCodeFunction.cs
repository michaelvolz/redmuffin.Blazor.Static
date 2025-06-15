using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace redmuffin.Blazor.StaticWeb.Api;

public class AuthCodeFunction
{
	private const string AuthCode = "edc3fd0e-3772-4b61-a2f3-25176e73e071";
	private readonly ILogger<AuthCodeFunction> _logger;

	public AuthCodeFunction(ILogger<AuthCodeFunction> logger)
	{
		_logger = logger;
	}

	[Function("GetAuthCode")]
	public IActionResult Run([
			HttpTrigger(AuthorizationLevel.Function, "get"),
		]
		HttpRequestData req)
	{
		_logger.LogInformation("AuthCodeFunction HTTP trigger processed a request.");
		return new OkObjectResult(new { authCode = AuthCode });
	}
}