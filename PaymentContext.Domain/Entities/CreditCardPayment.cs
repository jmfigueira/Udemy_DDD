using System;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string cardHolderNumber, string cardNumber, string lastTransactionNumber, DateTime paidDate,
        DateTime expireDate, decimal total, decimal totalPaid, string address, string document, string payer, string email)
        : base(paidDate, expireDate, total, totalPaid, address, document, payer, email)
        {
            CardHolderNumber = cardHolderNumber;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderNumber { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }
}