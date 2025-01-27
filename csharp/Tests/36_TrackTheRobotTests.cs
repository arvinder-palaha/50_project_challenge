namespace Tests;

using TrackTheRobot;

public class TrackTheRobotTests
{
    [Theory]
    [InlineData(new string[] { "right 10", "up 50", "left 30", "down 10" }, new int[] { -20, 40 })]
    [InlineData(new string[] { }, new int[] { 0, 0 })]
    [InlineData(new string[] { "right 100", "right 100", "up 500", "up 10000" }, new int[] { 200, 10500 })]
    public void Test1(string[] instructions, int[] expected)
    {
        Assert.Equal(expected, Program.TrackRobot(instructions));
    }
}
