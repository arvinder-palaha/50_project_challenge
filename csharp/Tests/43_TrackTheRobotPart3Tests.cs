namespace Tests;

using TrackTheRobotPart3;

public class TrackTheRobotPart3Tests
{
    [Theory]
    [InlineData("..<.<.", new int[] { 1, 1 })]
    [InlineData(">.<.<.", new int[] { 1, 0 })]
    [InlineData(">.<.<.<.", new int[] { 0, 0 })]
    [InlineData(">.<.<.<.<.", new int[] { 0, -1 })]
    [InlineData(">.<.<.<.<.<.", new int[] { 1, -1 })]
    public void TestTrackRobotPart3(string instructions, int[] expected)
    {
        Assert.Equal(expected, Program.TrackRobotPart3(instructions));
    }
}