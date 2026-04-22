using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public abstract class Payment
    {
        public IPaymentService _paymentService;
        public Payment(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public abstract void MakePayment(string paymentType);
    }
}
