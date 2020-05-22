using BookCatalog_Domain.AggregateModel.BookAggregate;
using BookCatalog_Domain.Base;

namespace BookCatalog_Domain.Events
{
    public class BookApprovedDomainEvent : IDomainEvent
    {
        public Book Book { get; }

        public BookApprovedDomainEvent(Book book)
        {
            Book = book;
        }
    }
}
