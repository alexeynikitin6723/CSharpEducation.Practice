using System;

namespace Practice2.Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintArr(NewArr(5,6));
        }

        static int[,] NewArr(int m, int n)
        {
            int[,] arr = new int[m,n];
            Random random = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i,j] = random.Next(0, 100);
                }
            }    
            return arr;
        }

        static void PrintArr(int[,] arr)
        {
            int rows = arr.GetUpperBound(0)+1;
            int columns = arr.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}