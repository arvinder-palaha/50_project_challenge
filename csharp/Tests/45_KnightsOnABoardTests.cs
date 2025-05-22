namespace Tests;

using KnightsOnABoard;

public class KnightsOnABoardTests
{
    [Fact]
    public void TestCannotCapture_True()
    {
        int[,] board = new int[,] {
            { 0, 0, 0, 1, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 0, 1, 0, 1, 0 },
            { 0, 1, 0, 0, 0, 1, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 1, 0, 0, 0 }
        };
        Assert.True(Program.CannotCapture(board));
    }

    [Fact]
    public void TestCannotCapture_False()
    {
        int[,] board = new int[,] {
            {1, 0, 1, 0, 1, 0, 1, 0},
            {0, 1, 0, 1, 0, 1, 0, 1},
            {1, 0, 1, 0, 1, 0, 1, 0},
            {0, 0, 0, 1, 0, 1, 0, 1},
            {1, 0, 0, 0, 1, 0, 1, 0},
            {0, 0, 0, 0, 0, 1, 0, 1},
            {1, 0, 1, 0, 1, 0, 1, 0},
            {1, 0, 0, 1, 0, 0, 0, 1} 
        };
        Assert.False(Program.CannotCapture(board));
    }
}