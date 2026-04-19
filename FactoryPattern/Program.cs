using FactoryPattern.Services;
using System;

namespace CSharp_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int paymentType = 3;

            PaymentFactoryService paymentFactoryService = new PaymentFactoryService();
            var paymentObject = paymentFactoryService.CreatePaymentInstance(paymentType);

            Console.WriteLine(paymentObject.GetPaymentType());
            Console.ReadKey();
        }
    }
}
