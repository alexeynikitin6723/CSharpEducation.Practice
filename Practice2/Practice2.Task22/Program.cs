namespace Practice2.Task22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(1, 100);
            int attempt = 0;
            Console.WriteLine("Правила:\nДля выхода нажмите 0\nКоличество попыток 10\nВведите число:");
            while (true)
            {
                int answer = int.Parse(Console.ReadLine());
                if (answer == 0)
                {
                    break;
                }
                if (answer == n)
                {
                    Console.WriteLine("Вы угадали");
                    break;
                }
                if (answer < n)
                {
                    Console.WriteLine($"Загаданное число больше {answer}");
                }
                else
                {
                    Console.WriteLine($"Загаданное число меньше {answer}");
                }
                attempt++;
                if (attempt == 10)
                {
                    Console.WriteLine($"Вы проиграли");
                }
            }
        }
    }
}