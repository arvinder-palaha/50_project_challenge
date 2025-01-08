namespace Tests;

using CharactersCounterpartCharCode;

public class CharactersCounterpartCharCodeTests
{
    [Theory]
    [InlineData('A', 97)]
    [InlineData('a', 65)]
    public void Test_CounterpartCharCode(char character, int expected)
    {
        Assert.Equal(expected, Program.CounterpartCharCode(character));
    }
}
