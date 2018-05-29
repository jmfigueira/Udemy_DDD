using PaymentContext.Domain.ValueObjects;
using System;

namespace PaymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barcode, string boletoNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, Document document, Address address, string payer, Email email)
        : base(paidDate, expireDate, total, totalPaid, address, document, payer, email)
        {
            Barcode = barcode;
            BoletoNumber = boletoNumber;
        }

        public string Barcode { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}