namespace HelloCi.Web;
public class Calculator
{
    public double Calculate(double a, double b, string op) => op switch
    {
        "add" => a + b,
        "subtract" => a - b,
        "multiply" => a * b,
        "divide" => b == 0
            ? throw new DivideByZeroException("Cannot divide by zero.")
            : a / b,
        _ => throw new ArgumentException("Unknown operation.")
    };
}