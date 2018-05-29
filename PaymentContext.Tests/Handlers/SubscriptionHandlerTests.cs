using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        public void ShouldReturnErrorWhenDocumentExist()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "BRUCE";
            command.LastName = "WAYNE";
            command.Document = "99999999999";
            command.Email = "hello@balta.io2";
            command.BarCode = "1234567890";
            command.BoletoCode = "1234567890";
            command.BoletoNumber = "123456789";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.PayerDocument = "123456789";
            command.PayerDocumentType = EDocumentType.CPF;
            command.Payer = "WAYNE CORP";
            command.PayerEmail = "batman@dc.com";
            command.Street = "asadasd";
            command.Number = "aasdas";
            command.City = "asaas";
            command.Neighborghood = "asssa";
            command.State = "asas";
            command.Country = "asasa";
            command.ZipCode = "ass";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}