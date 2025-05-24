namespace Tests;

using MiserableParodyOfACalculator;

public class MiserableParodyOfACalculatorTests
{
    [Theory]
    [InlineData("23+4", 27)]
    [InlineData("45-15", 30)]
    [InlineData("13+2-5*2", 5)]
    [InlineData("49/7*2-3", 11)]
    public void TestCalculator_SimpleExpressions(string expression, double expected)
    {
        double result = Program.Calculator(expression);
        Assert.Equal(expected, result);
    }
}
