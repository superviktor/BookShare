using BookCatalog_Domain.AggregateModel.BookAggregate;
using MediatR;

namespace BookCatalog_Domain.Events
{
    public class NewBookDomainEvent : INotification
    {
        public Book Book { get; }

        public NewBookDomainEvent(Book book)
        {
            Book = book;
        }
    }
}
