using HelloCi.Web;

namespace HelloCi.Tests;

public class GreeterTests
{
    [Fact]
    public void Greet_WithName() => Assert.Equal("Hello, Jahid!", new Greeter().Greet("Jahid"));

    [Fact]
    public void Greet_Empty() => Assert.Equal("Hello, stranger!", new Greeter().Greet(""));
}