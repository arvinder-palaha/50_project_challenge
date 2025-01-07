namespace Tests;

using ConvertArrayItemsToAString;

public class ConvertArrayItemsToAStringTests
{
    [Theory]
    [InlineData(new object[] { 1, 2, "a", "b" }, new object[] { "1", "2", "a", "b" })]
    [InlineData(new object[] { "abc", 123, "def", 456 }, new object[] { "abc", "123", "def", "456" })]
    [InlineData(new object[] { 1, 2, 3, 17, 24, 3, "a", "123b" }, new object[] { "1", "2", "3", "17", "24", "3", "a", "123b" })]
    [InlineData(new object[] { }, new object[] { })]
    public void ParseArray_ReturnsCorrectResult(object[] input, object[] expected)
    {
        var result = Program.ParseArray(input);
        Assert.Equal(expected, result);
    }
}
