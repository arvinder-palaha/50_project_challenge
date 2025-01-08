namespace Tests;

using CharactersCounterpartCharCode;

public class CharactersCounterpartCharCodeTests
{
    [Theory]
    [InlineData('A', 97)]
    [InlineData('a', 65)]
    [InlineData('B', 98)]
    [InlineData('b', 66)]
    [InlineData('C', 99)]
    [InlineData('c', 67)]
    public void Test_CounterpartCharCode(char character, int expected)
    {
        Assert.Equal(expected, Program.CounterpartCharCode(character));
    }
}
