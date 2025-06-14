using System.Text;
using System.Text.Json;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;

namespace redmuffin.Blazor.StaticWeb.Features.Pages.VideosPage;

public partial class Redirect
{
	private string? _accessToken;
	private string? _authCode;
	private string? _error;

	[Inject]
	private NavigationManager Navigation { get; set; } = default!;

	[Inject]
	private ILocalStorageService LocalStorage { get; set; } = default!;

	[Inject]
	private HttpClient Http { get; set; } = default!;

	protected override async Task OnInitializedAsync()
	{
		var uri = new Uri(Navigation.Uri);
		var query = QueryHelpers.ParseQuery(uri.Query);
		if (query.TryGetValue("code", out var codeVal))
		{
			_authCode = codeVal;
			await LocalStorage.SetItemAsync("raindrop_auth_code", _authCode);
			await ExchangeCodeForTokenAsync(_authCode!);
		}
	}

	private async Task ExchangeCodeForTokenAsync(string code)
	{
		var clientId = "684c73df642469e7c1969f8e";
		var clientSecret = "16b3a598-9727-4250-86e7-ba87f117adc0";
		var redirectUri = Navigation.BaseUri.TrimEnd('/') + "/redirect";

		var content = new StringContent(
			$"grant_type=authorization_code&code={code}&client_id={clientId}&client_secret={clientSecret}&redirect_uri={Uri.EscapeDataString(redirectUri)}",
			Encoding.UTF8, "application/x-www-form-urlencoded");

		try
		{
			var response = await Http.PostAsync("https://raindrop.io/oauth/access_token", content);
			if (response.IsSuccessStatusCode)
			{
				var json = await response.Content.ReadAsStringAsync();
				using var doc = JsonDocument.Parse(json);
				if (doc.RootElement.TryGetProperty("access_token", out var tokenElem))
				{
					_accessToken = tokenElem.GetString();
					await LocalStorage.SetItemAsync("raindrop_access_token", _accessToken);
				}
				else
				{
					_error = "No access_token in response.";
				}
			}
			else
			{
				_error = $"Token request failed: {response.StatusCode}";
			}
		}
		catch (Exception ex)
		{
			_error = ex.Message;
		}
	}
}