using AutoMapper;
using BookCatalog.Application.Application.Base;
using BookCatalog.Application.Application.Commands;
using BookCatalog.Infrastructure.Entity;
using BookCatalog.Infrastructure.Repository;
using BookCatalog_Domain.AggregateModel.BookAggregate;
using System.Threading.Tasks;

namespace BookCatalog.Application.Application.Handlers.Command
{
    public class CreateBookCommandHandler : ICommandHandler<CreateBookCommand>
    {
        private readonly IMapper bookMapper;
        private readonly IBookRepository bookRepository;

        public CreateBookCommandHandler(IMapper bookMapper, IBookRepository bookRepository)
        {
            this.bookMapper = bookMapper;
            this.bookRepository = bookRepository;
        }
        public async Task HandleAsync(CreateBookCommand createBookCommand)
        {
            var book = new Book(createBookCommand.Name, createBookCommand.Annotation);
            foreach (var author in createBookCommand.Authors)
            {
                book.AddAuthor(author.FirstName, author.LastName, author.CountryName, author.CountryCode);
            }
            foreach (var categoryName in createBookCommand.CategoryNames)
            {
                book.AddCategory(categoryName);
            }

            var bookEntity = this.bookMapper.Map<BookEntity>(book);

            await this.bookRepository.AddAsync(bookEntity).ConfigureAwait(false);

            //emit integration event book created
        }
    }
}
