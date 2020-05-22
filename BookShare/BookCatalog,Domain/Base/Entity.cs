using System;
using System.Collections.Generic;

namespace BookCatalog_Domain.Base
{
    public abstract class Entity
    {
        public virtual Guid Id { get; set; }

        private List<object> _domainEvents;
        public IReadOnlyCollection<object> DomaibjenEvents => _domainEvents?.AsReadOnly();

        public void AddDomainEvent(object domainEvent)
        {
            _domainEvents = _domainEvents ?? new List<object>();
            _domainEvents.Add(domainEvent);
        }

        public void RemoveDomainEvent(object eventItem)
        {
            _domainEvents?.Remove(eventItem);
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }
    }
}
