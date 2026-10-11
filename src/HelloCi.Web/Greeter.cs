namespace HelloCi.Web;

public class Greeter
{
    public string Greet(string name) =>
        string.IsNullOrWhiteSpace(name) ? "Hello, stranger!" : $"Hello, {name}!";
}