
namespace Practice3.Task4
{
    public class Book
    {
        private string title;
        private string author;

        public Book()
        {
            this.title = "Unnamed";
            this.author = "Unnamed";
        }
        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public string Title
        {
            get => this.title;
        }
        public string Author
        {
            get => this.author;
        }
    }
}
