using BridgePattern;
using System;

namespace CSharp_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentFactory paymentFactory = new PaymentFactory();
            var payentObj = paymentFactory.GetPayment("Card", "Axis");
            payentObj.MakePayment("Net Banking");

            //Payment payment = new NetBankingPayment();
            //payment.paymentService = new CitiBankPayment();
            //payment.MakePayment("Net Banking");


            Console.ReadKey();
        }
    }
}