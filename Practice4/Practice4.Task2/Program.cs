using Practice4.Task1;

namespace Practice4.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 3.54;
            double y = 2.51;
            int x1 = 4;
            int y1 = 5;
            Console.WriteLine(MathHelper.Add(x,y));
            Console.WriteLine(MathHelper.Substract(x,y));
            Console.WriteLine(MathHelper.Multiple(x,y));
            Console.WriteLine(MathHelper.Divide(x,y));

            Console.WriteLine(MathHelper.Add(x1, y1));
            Console.WriteLine(MathHelper.Substract(x1, y1));
            Console.WriteLine(MathHelper.Multiple(x1, y1));
            Console.WriteLine(MathHelper.Divide(x1, y1));
        }
    }
}