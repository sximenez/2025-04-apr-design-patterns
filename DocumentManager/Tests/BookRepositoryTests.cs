using C_Domain;
using D_DataAccess;
using E_Database;
using Microsoft.Extensions.Configuration;
using Xunit;

namespace Tests
{
    public class BookRepositoryTests()
    {
        [Fact]
        public void FetchBooks_ShouldReturnDomainObjects()
        {
            var testAppSettings = new Dictionary<string, string?>
            {
                { "FilePaths:Default", "DocumentManager/Tests/Data/test-books.csv" }
            };

            IConfiguration configuration = new ConfigurationBuilder()
                .AddInMemoryCollection(testAppSettings)
                .Build();

            var repository = new BookRepository(new BookMapper(), new BookDatabase(configuration));

            IEnumerable<Book> actual = repository.FetchBooks();

            Assert.NotNull(actual);
            Assert.True(actual.Any());
        }
    }
}