using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class AxisBankPayment : IPaymentService
    {
        public void ProcessPayment(string paymentType)
        {
            Console.WriteLine("Axis Bank Payment");
        }
    }
}
