namespace Practice3.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(3,4);
            Point p2 = new Point(6,9);
            Console.WriteLine(Point.Length(p1, p2));
        }
    }
}