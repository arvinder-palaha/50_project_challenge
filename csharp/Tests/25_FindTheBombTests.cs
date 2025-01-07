namespace Tests;

using FindTheBomb;

public class FindTheBombTests
{
    [Theory]
    [InlineData("There is a bomb.", "Duck!!!")]
    [InlineData("Hey, did you think there is a bomb?", "Duck!!!")]
    [InlineData("This goes boom!!!", "There is no bomb, relax.")]
    public void FindTheBomb_ReturnsCorrectResult(string input, string expected)
    {
        var result = Program.FindTheBomb(input);
        Assert.Equal(expected, result);
    }
}
