namespace Practice.Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(char.ToUpper(str[0])+str.Substring(1).ToLower());
        }

    }
}