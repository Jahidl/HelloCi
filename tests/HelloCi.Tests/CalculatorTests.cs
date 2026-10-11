using HelloCi.Web;
namespace HelloCi.Tests;

public class CalculatorTests
{
    private readonly Calculator _calc = new();

    [Theory]
    [InlineData(2, 3, "add", 5)]
    [InlineData(5, 3, "subtract", 2)]
    [InlineData(4, 3, "multiply", 12)]
    [InlineData(10, 4, "divide", 2.5)]
    public void Calculate_Works(double a, double b, string op, double expected)
        => Assert.Equal(expected, _calc.Calculate(a, b, op));

    [Fact]
    public void Divide_ByZero_Throws()
        => Assert.Throws<DivideByZeroException>(() => _calc.Calculate(1, 0, "divide"));

    [Fact]
    public void Unknown_Op_Throws()
        => Assert.Throws<ArgumentException>(() => _calc.Calculate(1, 1, "pow"));
}