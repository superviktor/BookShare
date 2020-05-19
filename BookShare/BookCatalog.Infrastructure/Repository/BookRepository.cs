using BookCatalog.Infrastructure.AzureTable;
using BookCatalog.Infrastructure.Entity;
using BookCatalog.Infrastructure.Repository;
using System.Threading.Tasks;

namespace BookCatalog.Infrastructure
{
    public class BookRepository : AzureTableRepository, IBookRepository
    {
        private const string TableName = "Books";
        public BookRepository(string connectionString) : base(connectionString)
        {
        }

        public async Task AddAsync(Book book)
        {
            await AddOrUpdateAsync(TableName, book).ConfigureAwait(false);
        }
    }
}
