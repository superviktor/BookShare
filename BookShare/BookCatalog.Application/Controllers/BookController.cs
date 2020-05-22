using AutoMapper;
using BookCatalog.Application.Application.Commands;
using BookCatalog.Application.Application.Handlers.Command;
using BookCatalog.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookCatalog.Application.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMapper bookMapper;
        private readonly IBookRepository bookRepository;

        public BookController(IMapper bookMapper, IBookRepository bookRepository)
        {
            this.bookMapper = bookMapper;
            this.bookRepository = bookRepository;
        }
        [HttpPost]
        public async Task CreateBookAsync([FromBody] CreateBookCommand createBookCommand)
        {
            var createBookCommandHandler = new CreateBookCommandHandler(bookMapper, bookRepository);
            await createBookCommandHandler.HandleAsync(createBookCommand).ConfigureAwait(false);
        }
    }
}