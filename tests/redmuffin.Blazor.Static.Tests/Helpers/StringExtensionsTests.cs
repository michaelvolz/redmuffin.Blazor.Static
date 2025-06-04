using redmuffin.Blazor.Static.Helpers;
#pragma warning disable CA1707

namespace redmuffin.Blazor.Static.Tests.Helpers;

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