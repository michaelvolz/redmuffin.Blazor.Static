﻿using Markdig;
using Microsoft.AspNetCore.Components;

namespace redmuffin.Blazor.StaticWeb.Features.Pages.ExamplePage;

public partial class Example : ComponentBase
{
	private MarkupString _markdownText = new("n/a");

	protected override async Task OnInitializedAsync()
	{
		var pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();
		if (Http != null) _markdownText = new MarkupString(Markdown.ToHtml(await Http.GetStringAsync("Example.md"), pipeline));
	}
}