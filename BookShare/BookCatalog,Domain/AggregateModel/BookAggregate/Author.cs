using BookCatalog_Domain.Base;
using System.Collections.Generic;

namespace BookCatalog_Domain.AggregateModel.BookAggregate
{
    public class Author : ValueObject
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Country Country { get; private set; }

        public Author()
        {
        }
        public Author(string firstName, string lastName, Country country)
        {
            FirstName = firstName;
            LastName = lastName;
            Country = country;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return FirstName;
            yield return LastName;
            yield return Country;
        }
    }
}
