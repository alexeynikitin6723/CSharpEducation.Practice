
namespace Practice3.Task5
{
    public class Book
    {
        private string title;
        private string author;
        private int yearOfPublishing;

        /*public Book()
        {
            this.title = "Unnamed";
            this.author = "Unnamed";
        }*/
        public Book(string title) : this(title, "unnamed", 0) { }
        public Book(string title, string author) : this(title, author, 0) { }
        public Book(string title, string author, int year)
        {
            this.title = title;
            this.author = author;
            this.yearOfPublishing = year;
        }

        public string Title
        {
            get => this.title;
        }
        public string Author
        {
            get => this.author;
            set => this.author = value;
        }
        public int YearOfPublishing
        {
            get => this.yearOfPublishing;
            set => this.yearOfPublishing = value;
        }
    }
}
