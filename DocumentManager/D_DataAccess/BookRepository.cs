using C_Domain;
using C_Domain.Interfaces;

namespace D_DataAccess
{
    public class BookRepository : IBookRepository
    {
        private readonly IBookMapper _mapper;
        private readonly IBookDatabase _database;

        public BookRepository(IBookMapper mapper, IBookDatabase database)
        {
            _mapper = mapper;
            _database = database;
        }

        public IEnumerable<Book> FetchBooks()
        {
            return File.ReadAllLines(_database.FilePath).Select(_mapper.MapToBook);
        }
    }
}
