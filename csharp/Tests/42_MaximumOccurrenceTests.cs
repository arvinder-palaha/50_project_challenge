namespace Tests;

using MaximumOccurrence;

public class MaximumOccurrenceTests
{
    [Theory]
    [InlineData("Computer Science", "e")]
    [InlineData("Edabit", "No Repetition")]
    [InlineData("system admin", "m, s")]
    [InlineData("the quick brown fox jumps over the lazy dog", " ")]
    public void TestMaximumOccurrence(string text, string expected)
    {
        Assert.Equal(expected, Program.MaxOccur(text));
    }
}
