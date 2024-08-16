namespace Practice2.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту:");
            int high = int.Parse(Console.ReadLine());
            RightTriangleWithCustomSymbol(high, '-');

           
        }

        static void LeftTriangle(int high)
        {
            for (int i = 0; i <= high; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void RightTriangle(int high)
        {
            for (int i = 0; i <= high; i++)
            {
                for (int j = 0; j < high; j++)
                {
                    Console.Write((high - i > j) ? " " : "*");
 
                }
                Console.WriteLine();
            }
        }

        static void LeftTriangleWithCustomSymbol(int high, char symbol)
        {
            for (int i = 0; i <= high; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        static void RightTriangleWithCustomSymbol(int high, char symbol)
        {
            for (int i = 0; i <= high; i++)
            {
                for (int j = 0; j < high; j++)
                {
                    Console.Write((high - i > j) ? " " : symbol);

                }
                Console.WriteLine();
            }
        }
    }
}