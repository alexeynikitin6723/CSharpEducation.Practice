namespace Practice2.Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[int.Parse(args[0])];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(args[1]);
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}