using BookCatalog_Domain.AggregateModel.BookAggregate;
using BookCatalog_Domain.Base;

namespace BookCatalog_Domain.Events
{
    public class BookRejectedDomainEvent : IDomainEvent
    {
        public Book Book { get; }

        public BookRejectedDomainEvent(Book book)
        {
            Book = book;
        }
    }
}
