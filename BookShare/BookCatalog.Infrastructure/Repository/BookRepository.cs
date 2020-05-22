using BookCatalog.Infrastructure.AzureTable;
using BookCatalog.Infrastructure.Entity;
using BookCatalog.Infrastructure.Options;
using BookCatalog.Infrastructure.Repository;
using System.Threading.Tasks;

namespace BookCatalog.Infrastructure
{
    public class BookRepository : AzureTableRepository, IBookRepository
    {
        private const string TableName = "Books";
        public BookRepository(AzureTablesOptions azureTablesOptions) : base(azureTablesOptions.ConnectionString)
        {
        }

        public async Task AddAsync(BookEntity book)
        {
            await AddOrUpdateAsync(TableName, book).ConfigureAwait(false);
        }
    }
}
