namespace Tests;

public class ImaginaryCodingInterviewTests
{
    [Theory]
    [InlineData(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 120, "qualified")]
    [InlineData(new int[] { 2, 3, 8, 6, 5, 12, 10, 18 }, 64, "qualified")]
    [InlineData(new int[] { 5, 5, 10, 10, 25, 15, 20, 20 }, 120, "disqualified")]
    [InlineData(new int[] { 5, 5, 10, 10, 15, 15, 20 }, 120, "disqualified")]
    [InlineData(new int[] { 5, 5, 10, 10, 15, 15, 20, 20 }, 130, "disqualified")]
    public void Test1(int[] times, int totalTime, string expected)
    {
        Assert.Equal(expected, ImaginaryCodingInterview.Program.Interview(times, totalTime));
    }
}
