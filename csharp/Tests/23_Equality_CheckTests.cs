namespace Tests;

using EqualityCheck;

public class EqualityCheckTests
{
    [Theory]
    [InlineData(1, 1, true)]
    [InlineData(1, "1", false)]
    [InlineData(0, false, false)]
    public void CheckEquality_ReturnsCorrectResult(object a, object b, bool expected)
    {
        var result = Program.CheckEquality(a, b);
        Assert.Equal(expected, result);
    }
}
