
namespace Practice3.Task2
{
    public class Student
    {
        private string name;
        private int age;
        private double averageMark;
        public Student() : this("Unnamed", 0) { }
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public double AverageMark
        {
            get => averageMark;

            set
            {
                if (averageMark < 0 && averageMark > 5)
                {
                    throw new ArgumentException("Средний балл должен находится в диапазоне от 0 до 5");
                }
                averageMark = value;
            }
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
            Console.WriteLine($"Имя: {this.Name}, возраст: {this.Age}, средний балл: {this.AverageMark}");
        }
    }
}
