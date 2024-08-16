
namespace Practice3.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3;
            double b = 2;
            Console.WriteLine($"Add: {Calculator.Add(a,b)}");
            Console.WriteLine($"Substract: {Calculator.Substract(a,b)}");
            Console.WriteLine($"Multiply: {Calculator.Multiply(a,b)}");
            Console.WriteLine($"Divide: {Calculator.Divide(a,b)}");

        }
    }
}