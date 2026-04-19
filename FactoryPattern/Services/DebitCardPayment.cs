using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Services
{
    public class DebitCardPayment : IPaymentService
    {
        public string GetPaymentType()
        {
            return "Debit Card";
        }
    }
}
