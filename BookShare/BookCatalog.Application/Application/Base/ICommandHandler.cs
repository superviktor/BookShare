using System.Threading.Tasks;

namespace BookCatalog.Application.Application.Base
{
    interface ICommandHandler<T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}
