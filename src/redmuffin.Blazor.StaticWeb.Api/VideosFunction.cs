using System.Net;
using System.Net.Http.Headers;
using System.Text.Json;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

#pragma warning disable CA1848 // Use the LoggerMessage delegates
#pragma warning disable CA1001 // Types that own disposable fields should be disposable
#pragma warning disable MA0004 // Use Task.ConfigureAwait(false)

namespace redmuffin.Blazor.StaticWeb.Api;

public class VideosFunction(ILogger<VideosFunction> logger, IOptions<Settings> settings)
{
	private const string TargetCollectionId = "56109697";

	private readonly HttpClient _httpClient = new();
	private readonly Settings _settings = settings.Value;

	[Function("ListVideos")]
	public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequestData req)
	{
		logger.LogInformation("Videos function processed a request. Settings: {RainDropTestToken}", _settings.RainDropTestToken);

		_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _settings.RainDropTestToken);

		try
		{
			// API endpoint to get raindrops from a specific collection, sorted by creation date in descending order
			var apiUrl = $"https://api.raindrop.io/rest/v1/raindrops/{TargetCollectionId}?sort=-created";
			logger.LogInformation("Fetching videos from Raindrop API: {ApiUrl}", apiUrl);

			var response = await _httpClient.GetAsync(apiUrl);
			var json = await response.Content.ReadAsStringAsync();

			if (response.IsSuccessStatusCode)
			{
				logger.LogInformation("Successfully received response from Raindrop API.");
				// Assuming the response is a JSON array of items.
				// You might need to adjust the deserialization based on the actual Raindrop API response structure.
				using var jsonDoc = JsonDocument.Parse(json);
				var items = jsonDoc.RootElement.TryGetProperty("items", out var itemsElement) ? itemsElement.Clone() : jsonDoc.RootElement.Clone();

				var okResp = req.CreateResponse(HttpStatusCode.OK);
				await okResp.WriteAsJsonAsync(items);
				return okResp;
			}

			logger.LogWarning("Raindrop API request failed with status code: {StatusCode}. Response: {Response}", response.StatusCode, json);
			var errResp = req.CreateResponse(HttpStatusCode.BadRequest);
			await errResp.WriteAsJsonAsync(new { Error = $"Raindrop API request failed: {response.StatusCode}", Details = json });
			return errResp;
		}
		catch (Exception ex)
		{
			logger.LogError(ex, "An error occurred while fetching videos from Raindrop.");
			var errResp = req.CreateResponse(HttpStatusCode.InternalServerError);
			await errResp.WriteAsJsonAsync(new { Error = ex.Message });
			return errResp;
		}
	}
}