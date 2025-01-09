namespace Tests;

using FindTheVertexOfQuadratic;

public class FindTheVertexOfQuadraticTests
{
    [Theory]
    [InlineData(1, 0, 25, 0, 25)]
    [InlineData(-1, 0, 25, 0, 25)]
    [InlineData(1, 10, 4, -5, -21)]
    public void FindVertexReturnsCorrectVertex(int a, int b, int c, double x, double y)
    {
        Assert.Equal(new double[] { x, y }, Program.FindVertex(a, b, c));
    }
}

