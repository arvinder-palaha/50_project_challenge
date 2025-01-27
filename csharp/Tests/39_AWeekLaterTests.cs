namespace Tests;

using AWeekLater;
public class AWeekLaterTests
{
    [Theory]
    [InlineData("12/03/2020", "19/03/2020")]
    [InlineData("21/12/1989", "28/12/1989")]
    [InlineData("01/01/2000", "08/01/2000")]
    public void TestAWeekLater(string input, string expectedOutput)
    {
        Assert.Equal(expectedOutput, Program.WeekAfter(input));
    }
}