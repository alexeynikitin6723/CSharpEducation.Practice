namespace Practice2.Task25
{
    internal class Program
    {
        enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 7:");
            int input = Convert.ToInt32(Console.ReadLine());
            DayOfWeek day = (DayOfWeek)input;
            Console.WriteLine($"Выбранный день недели: {day}");
        }
    }
}
