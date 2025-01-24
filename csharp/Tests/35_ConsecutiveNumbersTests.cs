namespace Tests;

using ConsecutiveNumbers;

public class ConsecutiveNumbersTests
{
    [Theory]
    [InlineData(new int[] { 5, 1, 4, 3, 2 }, true)]
    [InlineData(new int[] { 5, 1, 4, 3, 2, 8 }, false)]
    [InlineData(new int[] { 5, 6, 7, 8, 9, 9 }, false)]
    public void ConsecutiveNumbersReturnsCorrectResult(int[] arr, bool expected)
    {
        Assert.Equal(expected, Program.Cons(arr));
    }
}

