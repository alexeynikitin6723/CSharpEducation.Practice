using System.Linq;

namespace Practice2.Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int len = r.Next(50, 100);
            int[] arr = new int[len];
            for(int i = 0; i < len; i++)
            {
                arr[i] = r.Next(1, 100);
            }
            int min = arr.OrderBy(x => x).First();
            int max = arr.OrderBy(x => x).Last();
            Console.WriteLine($"{max - min}");
        }
    }
}