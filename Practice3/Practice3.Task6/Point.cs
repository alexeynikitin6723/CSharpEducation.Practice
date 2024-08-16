

namespace Practice3.Task6
{
    public struct Point
    {
        public int X;
        public int Y;
        
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public static double Length(Point p1, Point p2)
        {
            return Math.Sqrt((p2.X - p1.X) * (p2.X - p1.X) + (p2.Y - p1.Y) * (p2.Y - p1.Y));
        }
    }
}
