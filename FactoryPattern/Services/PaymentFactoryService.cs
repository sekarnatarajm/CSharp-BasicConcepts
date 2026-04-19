using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Services
{
    public class PaymentFactoryService
    {
        public IPaymentService CreatePaymentInstance(int paymentTypeId)
        {
            IPaymentService paymentService = null;
            if (paymentTypeId == 1)
            {
                paymentService = new CreditCardPayment();
            }
            else if (paymentTypeId == 2)
            {
                paymentService = new DebitCardPayment();
            }
            else if (paymentTypeId == 3)
            {
                paymentService = new UPIPayment();
            }
            return paymentService;
        }   
    }
}
