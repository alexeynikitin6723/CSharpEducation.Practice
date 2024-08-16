namespace Practice2.Task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;
            Swap(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}");
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}