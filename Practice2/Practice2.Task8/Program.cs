namespace Practice2.Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] abc = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = abc[0];
            int b = abc[1];
            int c = abc[2];
            if (a == b || a == c || b == c)
            {
                a += 5;
                b += 5;
                c += 5;
            }
            else
            {
                Console.WriteLine("равных нет");
            }
        }

    }
}