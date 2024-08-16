namespace Practice2.Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] xy = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int x = xy[0];
            int y = xy[1];
            Console.WriteLine(CompareInt(x, y));
        }

        static bool CompareInt(int x, int y)
        {
            return x == y;
        }
    }
}