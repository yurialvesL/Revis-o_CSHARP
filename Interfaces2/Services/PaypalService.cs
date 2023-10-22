using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Interfaces2.Services
{
    public class PaypalService : IOnlinePaymentService
    {
        public double PaymentFee(double amount)
        {

            return amount + (amount * 0.02);
        }
        public double Interest(double amount, int months)
        {
             return amount+((amount*0.01)* months);
        }
    }
}
