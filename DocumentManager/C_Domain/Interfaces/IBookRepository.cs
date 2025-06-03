namespace C_Domain.Interfaces
{
    public interface IBookRepository
    {
        public IEnumerable<Book> FetchBooks();
    }
}
