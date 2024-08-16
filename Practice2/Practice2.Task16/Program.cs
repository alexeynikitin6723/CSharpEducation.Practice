namespace Practice2.Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            OppositeSign(ref n);
            Console.WriteLine(n);
        }

        static void OppositeSign(ref int n)
        {
            n = -n; 
        }
    }
}