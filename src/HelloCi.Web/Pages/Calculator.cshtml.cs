using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloCi.Web.Pages;

public class CalculatorModel : PageModel
{
    [BindProperty] public double A { get; set; }
    [BindProperty] public double B { get; set; }
    [BindProperty] public string Op { get; set; } = "add";

    public double? Result { get; set; }
    public string? Error { get; set; }

    public void OnPost()
    {
        try
        {
            Result = new Calculator().Calculate(A, B, Op);
        }
        catch (Exception ex) when (ex is DivideByZeroException or ArgumentException)
        {
            Error = ex.Message;
        }
    }
}