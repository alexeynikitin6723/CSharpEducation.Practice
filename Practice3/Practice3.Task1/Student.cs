
namespace Practice3.Task1
{
    public class Student
    {
        private string name;
        private int age;
        public Student() : this("Unnamed", 0) { }
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name {
            get => this.name;
            set => this.name = value;
        }
        public int Age
        {
            get => this.age;
            set => this.age = value;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {this.Name}, возраст: {this.Age}");
        }
    }
}
