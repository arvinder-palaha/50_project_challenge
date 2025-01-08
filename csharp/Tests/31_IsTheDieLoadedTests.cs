namespace Tests;

public class IsTheDieLoadedTests
{
    [Theory]
    [InlineData(new int[] { 44, 52, 33, 40, 41, 30 }, true)]
    [InlineData(new int[] { 34, 27, 23, 20, 32, 28 }, true)]
    [InlineData(new int[] { 10, 20, 11, 5, 19, 16 }, false)]
    public void Test1(int[] rolls, bool expected)
    {
        Assert.Equal(expected, IsTheDieLoaded.Program.FairDie(rolls));
    }
}

