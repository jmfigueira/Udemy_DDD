using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string number, string city, string neighborghood, string state, string country, string zipCode)
        {
            Street = street;
            Number = number;
            City = city;
            Neighborghood = neighborghood;
            State = state;
            Country = country;
            ZipCode = zipCode;

            AddNotifications(new Contract().Requires().HasMinLen(Street, 3, "Address.Street", "Rua deve conter pelo menos 3 caracteres"));
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string City { get; private set; }
        public string Neighborghood { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
    }
}