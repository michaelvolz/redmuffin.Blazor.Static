using redmuffin.Blazor.StaticWeb.Features.App;

namespace redmuffin.Blazor.StaticWeb.Tests.Features.App;

public class StringExtensionsTests
{
	[Theory]
	[InlineData("Blazor", "rozalB")]
	[InlineData("racecar", "racecar")]
	[InlineData("", "")]
	[InlineData(null, null)]
	public void ReverseString_ReturnsExpectedResult(string? input, string? expected)
	{
		var result = input.ReverseString();
		Assert.Equal(expected, result);
	}
}