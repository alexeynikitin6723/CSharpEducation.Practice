namespace Practice4.Task1
{
    public class MathHelper
    {

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Substract(double x, double y)
        {
            return x - y;
        }

        public static double Multiple(double x, double y)
        {
            return x * y;
        }

        public static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Деление на 0");
            }
            return x / y;
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Substract(int x, int y)
        {
            return x - y;
        }

        public static int Multiple(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Деление на 0");
            }
            return x / y;
        }

        public static float Add(float x, float y)
        {
            return x + y;
        }

        public static float Substract(float x, float y)
        {
            return x - y;
        }

        public static float Multiple(float x, float y)
        {
            return x * y;
        }

        public static float Divide(float x, float y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Деление на 0");
            }
            return x / y;
        }
    }
}