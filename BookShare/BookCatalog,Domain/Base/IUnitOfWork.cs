using System;
using System.Threading;
using System.Threading.Tasks;

namespace BookCatalog_Domain.Base
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
