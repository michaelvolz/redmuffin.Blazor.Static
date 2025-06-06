using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using redmuffin.Blazor.StaticWeb.Features.AppLayout;

namespace redmuffin.Blazor.StaticWeb;

public partial class App
{
	public ErrorBoundary ComponentErrorBoundary { get; set; } = default!;

	private static Task HandleNavigationAsync(NavigationContext args)
	{
		// Ensure the layout type is preserved for trimming
		_ = typeof(MainLayout);
		return Task.CompletedTask;
	}
}