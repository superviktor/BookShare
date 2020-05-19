using BookCatalog.Infrastructure.Entity;
using System.Threading.Tasks;

namespace BookCatalog.Infrastructure.Repository
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);
    }
}
