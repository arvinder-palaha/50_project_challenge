namespace Tests;

using Working9To5;

public class Working9To5Tests
{
    [Fact]
    public void TestWorking9To5()
    {
        Assert.Equal(240, Program.Working9To5(9, 17, 30, 1.5));
        Assert.Equal(84, Program.Working9To5(16, 18, 30, 1.8));
        Assert.Equal(52.5, Program.Working9To5(13.25, 15, 30, 1.5));
    }
}
