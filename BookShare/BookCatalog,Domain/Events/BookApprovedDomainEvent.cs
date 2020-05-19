using BookCatalog_Domain.AggregateModel.BookAggregate;
using MediatR;

namespace BookCatalog_Domain.Events
{
    public class BookApprovedDomainEvent : INotification
    {
        public Book Book { get; }

        public BookApprovedDomainEvent(Book book)
        {
            Book = book;
        }
    }
}
