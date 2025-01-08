namespace Tests;

using PowerRanger;

public class PowerRangerTests
{
    [Theory]
    [InlineData(2, 49, 65, 2)]
    [InlineData(3, 1, 27, 3)]
    [InlineData(10, 1, 5, 1)]
    [InlineData(5, 31, 33, 1)]
    [InlineData(4, 250, 1300, 3)]
    public void PowerRangerReturnsCorrectNumberOfValues(int n, int a, int b, int expected)
    {
        Assert.Equal(expected, Program.PowerRanger(n, a, b));
    }
}
