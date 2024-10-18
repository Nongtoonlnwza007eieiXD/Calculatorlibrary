namespace Calculator;
using Calculatorlibrary;
class Program
{
    static void Main(string[] args)
    {
        int a = 2;
        int b = 3;
        int c = Calculatorlibrary.Add(a,b);
        Console.WriteLine($"Result from Add({a},{b})is {c}");
    }
}
