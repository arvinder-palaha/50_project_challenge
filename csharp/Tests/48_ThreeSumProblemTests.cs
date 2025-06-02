using FluentAssertions;

namespace Tests;

using ThreeSumProblem;

public class ThreeSumProblemTests
{
    [Theory]
    [InlineData(new int[] { 0, 1, -1, -1, 2 }, "{ { 0, 1, -1 }, { -1, -1, 2 } }")]
    [InlineData(new int[] { 0, 0, 0, 5, -5 }, "{ { 0, 0, 0 }, { 0, 5, -5 } }")]
    [InlineData(new int[] { 1, 2, 3 }, "{ }")]
    [InlineData(new int[] { 1 }, "{ }")]
    public void Test1(int[] nums, string expected)
    {
        var result = Program.ThreeSum(nums);
        result.Should().Be(expected);
    }
}
