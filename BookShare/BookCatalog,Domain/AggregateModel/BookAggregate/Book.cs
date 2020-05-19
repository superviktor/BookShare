using BookCatalog_Domain.Base;
using BookCatalog_Domain.Events;
using System.Collections.Generic;
using System.Linq;

namespace BookCatalog_Domain.AggregateModel.BookAggregate
{
    public class Book : Entity, IAggregateRoot
    {
        public string Name { get; private set; }
        public string Annotation { get; private set; }
        public Status Status { get; private set; }

        private readonly List<Author> _authors;
        public IReadOnlyCollection<Author> Authors => _authors;

        private readonly List<Category> _categories;
        public IReadOnlyCollection<Category> Categories;

        protected Book()
        {
            _authors = new List<Author>();
            _categories = new List<Category>();
        }

        public Book(string name, string annotation)
        {
            Name = name;
            Annotation = annotation;
            Status = Status.AwaitingValidation;

            AddDomainEvent(new NewBookDomainEvent(this));
        }

        public void AddAuthor(string firstName, string lastName, Country country)
        {
            var existingAuthor = _authors.SingleOrDefault(author => author.FirstName == firstName && author.LastName == lastName && author.Country == country);
            if (existingAuthor == null)
            {
                var author = new Author(firstName, lastName, country);
                _authors.Add(author);
            }
        }

        public void AddCategory(string name)
        {
            var existingCategory = _categories.SingleOrDefault(category => category.Name == name);
            if (existingCategory == null)
            {
                var category = new Category(name);
                _categories.Add(category);
            }
        }

        public void SetApprovedStatus()
        {
            if (Status == Status.AwaitingValidation)
            {
                AddDomainEvent(new BookApprovedDomainEvent(this));
                Status = Status.Approved;
            }
        }

        public void SetRejectedStatus()
        {
            if (Status == Status.AwaitingValidation)
            {
                AddDomainEvent(new BookRejectedDomainEvent(this));
                Status = Status.Rejected;
            }
        }
    }
}
