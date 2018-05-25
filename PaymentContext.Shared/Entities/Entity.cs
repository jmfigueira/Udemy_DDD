using System;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity : ValueObject
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
    }
}