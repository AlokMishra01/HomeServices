﻿using HomeServices.Domain.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeServices.Domain.Common
{
    internal class BaseEntity : IEntity
    {
        private readonly List<BaseEvent> _domainEvents = new();
        public int Id { get; set; }

        [NotMapped]
        public IReadOnlyCollection<BaseEvent> DomainEvents => _domainEvents.AsReadOnly();

        public void AddDomaninEvent(BaseEvent domaninEvent) => _domainEvents.Add(domaninEvent);
        public void RemoveDomainEvent(BaseEvent domainEvent) => _domainEvents.Remove(domainEvent);
        public void ClearDomainEvents() => _domainEvents.Clear();

    }
}
