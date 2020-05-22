using BookCatalog_Domain.Base;
using System.Collections.Generic;

namespace BookCatalog_Domain.AggregateModel.BookAggregate
{
    public class Country : ValueObject
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public Country(string name, string code)
        {
            this.Name = name;
            this.Code = code;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Name;
            yield return Code;
        }
    }
}
