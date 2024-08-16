using System.Drawing;

namespace Practice2.Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[int.Parse(args[0])];
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}