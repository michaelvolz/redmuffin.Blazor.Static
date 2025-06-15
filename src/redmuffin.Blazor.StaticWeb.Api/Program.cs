using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using redmuffin.Blazor.StaticWeb.Api;

#pragma warning disable MA0042

var host = new HostBuilder()
	.ConfigureFunctionsWebApplication()
	.ConfigureServices((hostContext, services) =>
	{
		services.AddApplicationInsightsTelemetryWorkerService();
		services.ConfigureFunctionsApplicationInsights();
		services.Configure<Settings>(hostContext.Configuration.GetSection("Settings"));
	})
	.Build();

var settings = host.Services.GetRequiredService<IOptions<Settings>>().Value;

// Output settings to console for debugging
Console.WriteLine($"RainDropClientId: {settings.RainDropClientId}");
Console.WriteLine($"RainDropClientSecret: {settings.RainDropClientSecret}");
Console.WriteLine($"RainDropTestToken: {settings.RainDropTestToken}");

// Validate Settings
if (string.IsNullOrWhiteSpace(settings.RainDropClientId) ||
    string.IsNullOrWhiteSpace(settings.RainDropClientSecret) ||
    string.IsNullOrWhiteSpace(settings.RainDropTestToken))
	throw new InvalidOperationException("One or more settings are not configured. Please check local.settings.json or application settings.");

host.Run();