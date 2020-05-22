using BookCatalog_Domain.AggregateModel.BookAggregate;
using BookCatalog_Domain.Base;

namespace BookCatalog_Domain.Events
{
    public class BookCreatedDomainEvent : IDomainEvent
    {
        public Book Book { get; }

        public BookCreatedDomainEvent(Book book)
        {
            Book = book;
        }
    }
}
