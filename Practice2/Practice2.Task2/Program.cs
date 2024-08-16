namespace Practice2.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DegreeCToDegreeF(100));
        }

        static double MeterToKm(double length)
        {
            return length/1000;
        }

        static double CmToKm(double length)
        {
            return length*1000*100;
        }

        static double MeterPerSecToKmPerHour(double speed)
        {
            return speed * 3.6;
        }

        static double DegreeCToDegreeF(double temperature)
        {
            return 32 + temperature * 1.8;
        }
    }
}