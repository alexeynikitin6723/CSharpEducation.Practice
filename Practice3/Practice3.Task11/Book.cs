
namespace Practice3.Task11
{
    public class Book
    {
        private string title;
        private string author;


        public string Title
        {
            get => this.title;
            set => this.title = value;
        }
        public string Author
        {
            get => this.author;
            set => this.author = value;
        }

        public static string GetBookInformation(Book book)
        {
            return $"Title: {book.Title}, Author: {book.Author}";
        }
    }
}
