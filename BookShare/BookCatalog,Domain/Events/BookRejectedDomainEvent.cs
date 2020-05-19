using BookCatalog_Domain.AggregateModel.BookAggregate;
using MediatR;

namespace BookCatalog_Domain.Events
{
    public class BookRejectedDomainEvent : INotification
    {
        public Book Book { get; }

        public BookRejectedDomainEvent(Book book)
        {
            Book = book;
        }
    }
}
