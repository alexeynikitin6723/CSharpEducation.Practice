namespace Practice3.Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book() { Author = "Ford", Title = "StoryTale" };
            Console.WriteLine(Book.GetBookInformation(book));
        }
    }
}