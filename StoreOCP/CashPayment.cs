using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace StoreOCP
{
    class CashPayment : IPaymentMethod
    {
        public bool processPayment(double amount)
        {
            Console.WriteLine("Processing payment with Cash in CashPayment (Interface)");

            return true;
        }

        public static bool processPaymentD(double amount)
        {
            Console.WriteLine("Processing payment with Cash in CasPayment (Delegate)");
            return true;
        }
    }
}
