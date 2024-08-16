namespace Practice2.Task23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите год:");
            int year = int.Parse(Console.ReadLine());

            if (year % 400 == 0)
            {
                Console.WriteLine("Год високосный");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("Год не високосный");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("Год високосный");
            }
            else
            {
                Console.WriteLine("Год не високосный");
            }
        }
    }
}