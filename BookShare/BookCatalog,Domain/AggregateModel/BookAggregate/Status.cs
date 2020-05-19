using BookCatalog_Domain.Base;

namespace BookCatalog_Domain.AggregateModel.BookAggregate
{
    public class Status : Enumeration
    {
        public Status(int id, string name) : base(id, name)
        {
        }
        public static Status AwaitingValidation = new Status(1, nameof(AwaitingValidation).ToLowerInvariant());
        public static Status Approved = new Status(2, nameof(Approved).ToLowerInvariant());
        public static Status Rejected = new Status(3, nameof(Rejected).ToLowerInvariant());

    }
}
