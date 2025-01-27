namespace Tests;

using AlmostPalindrome;

public class AlmostPalindromeTests
{
    [Theory]
    [InlineData("abcdcbg", true)]
    [InlineData("abccia", true)]
    [InlineData("abcdaaa", false)]
    [InlineData("1234312", false)]
    public void TestAlmostPalindrome(string input, bool expected)
    {
        Assert.Equal(expected, Program.AlmostPalindrome(input));
    }
}

