using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class PaymentFactory
    {
        public Payment GetPayment(string paymentType, string bankName)
        {
            Payment? payment = default;
            if (paymentType == "Netbank")
            {
                if (bankName == "Axis")
                {
                    payment = new NetBankingPayment(new AxisBankPayment());
                }
                else if (bankName == "Citi")
                {
                    payment = new NetBankingPayment(new CitiBankPayment());
                }
            }
            else if (paymentType == "Card")
            {
                if (bankName == "Axis")
                {
                    payment = new CardPayment(new AxisBankPayment());
                }
                else if (bankName == "Citi")
                {
                    payment = new CardPayment(new CitiBankPayment());
                }
            }
            return payment;
        }
    }
}
