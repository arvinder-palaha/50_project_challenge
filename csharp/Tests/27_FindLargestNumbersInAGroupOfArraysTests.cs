namespace Tests;

using FindLargestNumbersInAGroupOfArrays;

public class FindLargestNumbersInAGroupOfArraysTests
{
    [Fact]
    public void Test1()
    {
        var testCases = new[]
        {
            (Input: new[] { new[] {4f, 2f, 7f, 1f}, new[] {20f, 70f, 40f, 90f}, new[] {1f, 2f, 0f} },
             Expected: new[] { 7f, 90f, 2f }),
            (Input: new[] { new[] {-34f, -54f, -74f}, new[] {-32f, -2f, -65f}, new[] {-54f, 7f, -43f} },
             Expected: new[] { -34f, -2f, 7f }),
            (Input: new[] { new[] {0.4321f, 0.7634f, 0.652f}, new[] {1.324f, 9.32f, 2.5423f, 6.4314f}, new[] {9f, 3f, 6f, 3f} },
             Expected: new[] { 0.7634f, 9.32f, 9f })
        };

        foreach (var (Input, Expected) in testCases)
        {
            Assert.Equal(Expected, Program.FindLargest(Input));
        }
    }
}