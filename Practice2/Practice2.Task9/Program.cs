namespace Practice2.Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrintArr(NewArr(5));
        }

        static int[] NewArr(int size)
        {
            int[] arr = new int[size];
            return arr;
        }

        static void PrintArr(int[] arr)
        {
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}