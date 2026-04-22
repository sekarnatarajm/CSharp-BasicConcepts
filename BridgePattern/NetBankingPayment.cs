using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class NetBankingPayment : Payment
    {
        public NetBankingPayment(IPaymentService paymentService) : base(paymentService)
        { }

        public override void MakePayment(string paymentType)
        {
            Console.WriteLine(paymentType);
            _paymentService.ProcessPayment(paymentType);
        }
    }
}
