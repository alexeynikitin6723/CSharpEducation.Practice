namespace Practice2.Task21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(1, 100);
            Console.WriteLine("Введите число.\nДля выхода нажмите 0");
            while(true)
            {
                int answer = int.Parse(Console.ReadLine());
                if (answer == 0)
                {
                    break;
                }
                if (answer == n) {
                    Console.WriteLine("Вы угадали");
                    break;
                }
            }
        }
    }
}