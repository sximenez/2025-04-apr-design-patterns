namespace C_Domain
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }

        public Book()
        {
            Title = string.Empty;
            Author = string.Empty;
            Category = string.Empty;
        }
    }
}