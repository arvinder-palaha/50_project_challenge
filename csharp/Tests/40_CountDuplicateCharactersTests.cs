namespace Tests;

using CountDuplicateCharacters;

public class CountDuplicateCharactersTests
{
    [Theory]
    [InlineData("abcde", 0)]
    [InlineData("aabbcde", 2)]
    [InlineData("Indivisibilities", 2)]
    [InlineData("Aa", 0)]
    public void TestCountDuplicateCharacters(string input, int expectedOutput)
    {
        Assert.Equal(expectedOutput, Program.CountDuplicateCharacters(input));
    }
}