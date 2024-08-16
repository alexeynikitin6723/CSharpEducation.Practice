namespace Practice2.Task24
{
    internal class Program
    {
        enum DayOfWeek
        {
            Monday,
            Tuesday, 
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Дни недели:");
            foreach(DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine(day.ToString());
            }
        }
    }
}
