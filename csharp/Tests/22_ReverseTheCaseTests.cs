namespace Tests;

using ReverseTheCase;

public class ReverseTheCaseTests
{
    [Theory]
    [InlineData("Happy Birthday", "hAPPY bIRTHDAY")]
    [InlineData("MANY THANKS", "many thanks")]
    [InlineData("sPoNtAnEoUs", "SpOnTaNeOuS")]
    public void ReverseTheCase_ReturnsCorrectString(string input, string expected)
    {
        var result = Program.ReverseTheCase(input);
        Assert.Equal(expected, result);
    }
}