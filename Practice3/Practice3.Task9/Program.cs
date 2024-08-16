namespace Practice3.Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Fix", 0);
            Student.ChangeName(student);
            Console.WriteLine(student.Name);
        }
    }
}