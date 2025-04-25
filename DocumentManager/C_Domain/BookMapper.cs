using C_Domain.Interfaces;

namespace C_Domain
{
    public class BookMapper : IBookMapper
    {
        public Book MapToBook(string line)
        {
            string[] parts = line.Split(',');

            return new Book
            {
                Title = parts[0],
                Author = parts[1],
                Category = parts[2]
            };
        }
    }
}