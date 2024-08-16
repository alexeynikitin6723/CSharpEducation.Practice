
namespace Practice3.Task8
{
    public struct Rectangle
    {
        public double height;
        public double width;
        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public double Square()
        {
            return height * width;
        }
    }
}
