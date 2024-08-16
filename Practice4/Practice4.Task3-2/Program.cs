using Practice4.Task3;

namespace Practice4.Task3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Марина", 25);
            Person p3 = new Person("Владимир", 53);
            p1.PrintInformation();
            p2.PrintInformation();
            p3.PrintInformation();
        }
    }
}