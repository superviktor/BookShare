using BookCatalog_Domain.Base;

namespace BookCatalog_Domain.AggregateModel.BookAggregate
{
    public class Country : Enumeration
    {
        public Country(int id, string name) : base(id, name)
        {
        }

        public static Country Usa = new Country(1, nameof(Usa).ToLowerInvariant());
        public static Country GreatBritain = new Country(2, nameof(GreatBritain).ToLowerInvariant());

    }
}
