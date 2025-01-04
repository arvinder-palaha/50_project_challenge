namespace Tests;

using ReturnIndexCapitalLatters;

public class ReturnIndexCapitalLattersTests
{
    [Theory]
    [InlineData("eDaBiT", new int[] { 1, 3, 5 })]
    [InlineData("eQuINoX", new int[] { 1, 3, 4, 6 })]
    [InlineData("determine", new int[] { })]
    [InlineData("STRIKE", new int[] { 0, 1, 2, 3, 4, 5 })]
    [InlineData("sUn", new int[] { 1 })]
    public void ReturnIndexCapitalLatters_ReturnsCorrectIndex(string input, int[] expected)
    {
        var result = Program.ReturnIndexCapitalLatters(input);
        Assert.Equal(expected, result);
    }
}

