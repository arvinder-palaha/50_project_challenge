namespace Tests;

using CollatzConjecture;

public class CollatzConjectureTests
{
    [Theory]
    [InlineData(2, 1)]
    [InlineData(3, 7)]
    [InlineData(10, 6)]
    [InlineData(1, 0)]
    public void Test1(int input, int expected)
    {
        Assert.Equal(expected, Program.Collatz(input));
    }
}
