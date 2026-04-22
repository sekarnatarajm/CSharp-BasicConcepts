using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class CitiBankPayment : IPaymentService
    {
        public void ProcessPayment(string paymentType)
        {
            Console.WriteLine("Citi Bank Payment");
        }
    }
}
