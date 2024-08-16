namespace Practice2.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EvaluateExpression(0,4,5));
        }

        static double EvaluateExpression(double a, double b, double f)
        {
            if (a == 0) {
                throw new DivideByZeroException("Деление на 0");
            }
            return (a + b - f / a) + f * a * a - (a + b);
        }
    }
}