namespace Tests;

using CountOnesInBinaryRepOfInteger;

public class CountOnesInBinaryRepOfIntegerTests
{
    [Theory]
    [InlineData(123, 6)]
    [InlineData(128, 1)]
    [InlineData(1, 1)]
    [InlineData(10, 2)]
    [InlineData(0, 0)]
    public void Test_CountOnesInBinaryRepOfInteger(int number, int expected)
    {
        Assert.Equal(expected, Program.CountOnesInBinaryRepOfInteger(number));
    }
}

