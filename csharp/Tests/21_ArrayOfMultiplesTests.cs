namespace Tests;

public class ArrayOfMultiplesTests
{
    [Theory]
    [InlineData(7, 5, new int[] { 7, 14, 21, 28, 35 })]
    [InlineData(12, 10, new int[] { 12, 24, 36, 48, 60, 72, 84, 96, 108, 120 })]
    [InlineData(17, 6, new int[] { 17, 34, 51, 68, 85, 102 })]
    public void ArrayOfMultiples_ReturnsCorrectArray(int num, int length, int[] expected)
    {
        var result = Program.ArrayOfMultiples(num, length);
        Assert.Equal(expected, result);
    }
}