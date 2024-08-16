namespace Practice4.Task3
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }
        public Person(): this("NoName", 0) { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void PrintInformation()
        {
            Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
        }
    }
}