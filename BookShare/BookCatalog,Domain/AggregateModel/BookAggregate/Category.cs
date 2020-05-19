using BookCatalog_Domain.Base;
using System.Collections.Generic;

namespace BookCatalog_Domain.AggregateModel.BookAggregate
{
    public class Category : ValueObject
    {
        public string Name { get; private set; }

        public Category()
        {
        }

        public Category(string name)
        {
            Name = name;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Name;
        }
    }
}
