namespace Practice2.Tasks14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = NewArr(5);
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            Console.WriteLine(String.Join(" ", arr));
        }

        static int[] NewArr(int n)
        {
            return new int[n];
        }
    }
}