namespace Tests;

using TrackTheRobotPart3;

public class TrackTheRobotPart3Tests
{
    [Theory]
    [InlineData("..<.<.", new int[] { 1, 1 })]
    [InlineData(">.<.<.", new int[] { -1, 1 })]
    [InlineData(">.<.<.<.", new int[] { -2, 1 })]
    [InlineData(">.<.<.<.<.", new int[] { -3, 1 })]
    [InlineData(">.<.<.<.<.<.", new int[] { -4, 1 })]
    public void TestTrackRobotPart3(string instructions, int[] expected)
    {
        Assert.Equal(expected, Program.TrackRobotPart3(instructions));
    }
}