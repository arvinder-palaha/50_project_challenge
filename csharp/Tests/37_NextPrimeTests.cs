namespace Tests;

using NextPrime;

public class NextPrimeTests
{
    [Theory]
    [InlineData(12, 13)]
    [InlineData(24, 29)]
    [InlineData(11, 11)]
    public void TestNextPrime(int input, int expectedOutput)
    {
        Assert.Equal(expectedOutput, Program.NextPrime(input));
    }
}
