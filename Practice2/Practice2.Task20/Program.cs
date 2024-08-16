using System.Linq;

namespace Practice2.Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int n = r.Next(50, 100);
            int m = r.Next(50, 100);
            int[,] arr = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = r.Next(1, 100);
                }
            }
            for (int i = 0; i < n; i++)
            {
                int max = 0;
                int min = 100;
                for (int j = 0; j < m; j++)
                {
                    if(max < arr[i, j])
                    {
                        max = arr[i, j];
                    }
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                    }
                }
                Console.WriteLine($"Строка {i}: {max-min}");
            }

        }
    }
}