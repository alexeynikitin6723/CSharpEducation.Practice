namespace Practice2.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PercentCharToStringCmd(args));
        }

        static double PercentCharToString()
        {
            string str = "gfhrthgh";
            char ch = 'g';
            return str.Count(c => c == ch) / (double)str.Length * 100;
        }
        static double PercentCharToStringConsole()
        {
            string str = Console.ReadLine();
            char ch = (char)Console.Read();
            return str.Count(c => c == ch) / (double)str.Length * 100;
        }

        static double PercentCharToStringCmd(string[] args)
        {
            string str = args[0];
            char ch = char.Parse(args[1]);
            return str.Count(c => c == ch) / (double)str.Length * 100;
        }
    }
}