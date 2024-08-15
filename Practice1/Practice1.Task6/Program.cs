namespace Practice1.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите, что известно: 1 - катет и гипотенуза, 2 - два катета");
            int choice = int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                Console.Write("Введите катет: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введите гипотенузу: ");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine($"Катет равен: {Math.Sqrt(c*c-a*a)}");
            }
            if (choice == 2)
            {
                Console.Write("Введите первый катет: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введите второй катет: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine($"Гипотенуза равна: {Math.Sqrt(b * b + a * a)}");
            }
        }
    }
}
