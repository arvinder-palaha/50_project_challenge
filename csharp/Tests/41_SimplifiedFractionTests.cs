namespace Tests;

using SimplifiedFraction;

public class SimplifiedFractionTests
{
    [Theory]
    [InlineData("4/6", "2/3")]
    [InlineData("10/11", "10/11")]
    [InlineData("100/400", "1/4")]
    [InlineData("8/4", "2")]
    public void TestSimplify(string fraction, string expected)
    {
        Assert.Equal(expected, Program.Simplify(fraction));
    }
}

