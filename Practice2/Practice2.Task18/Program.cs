using System.Linq;

namespace Practice2.Task18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, -2, 4, -6, 8, 10, 11, 12 };
            NonNegaticeNumber(arr, out int count);
            Console.WriteLine($"Arr: {String.Join(" ", arr)}, Neg: {count}");
        }

        static int[] NonNegaticeNumber(int[] array, out int delete)
        {
            delete = array.Where(x => x < 0).Count();
            return array.Where(x => x >= 0).ToArray();
        }
    }
}