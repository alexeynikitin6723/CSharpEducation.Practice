namespace Practice2.Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Исходный массив:");
            PrintArray(arr);

            int[] inverteArray = InvertArray(arr);

            Console.WriteLine("\nИнвертированный массив:");
            PrintArray(inverteArray);
        }
        static int[] InvertArray(int[] array)
        {
            Array.Reverse(array);
            return array;
        }

        static void PrintArray(int[] array)
        {
            foreach (int e in array)
            {
                Console.Write(e + " ");
            }
        }
    }
}