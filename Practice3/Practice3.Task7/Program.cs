namespace Practice3.Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MonthEnum month = MonthEnum.December;
            Console.WriteLine(NumberOfDaysInMonth(month));
        }

        public enum MonthEnum
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        public static int NumberOfDaysInMonth(MonthEnum month)
        {
            switch (month)
            {
                case MonthEnum.January:
                case MonthEnum.March:
                case MonthEnum.May:
                case MonthEnum.July:
                case MonthEnum.August:
                case MonthEnum.October:
                case MonthEnum.December:
                    return 31;
                case MonthEnum.April:
                case MonthEnum.June:
                case MonthEnum.September:
                case MonthEnum.November:
                    return 30;
                case MonthEnum.February:
                    return 28;
                default:
                    return 0;
            }
        }
    }
}