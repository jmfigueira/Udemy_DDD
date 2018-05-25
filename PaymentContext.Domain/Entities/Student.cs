using System;
using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        public Student(Name name, Document document, string email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public string Email { get; private set; }
        public Address Address { get; private set; }
        private IList<Subscription> _subscriptions;
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }
        public void AddSubscription(Subscription subscription)
        {
            foreach (var sub in Subscriptions)
                sub.Inactivate();

            _subscriptions.Add(subscription);
        }
    }
}