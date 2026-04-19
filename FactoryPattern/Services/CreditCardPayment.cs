using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Services
{
    public class CreditCardPayment : IPaymentService
    {
        public string GetPaymentType()
        {
            return "Credit Card";
        }
    }
}
