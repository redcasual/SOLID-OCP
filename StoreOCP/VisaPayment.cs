using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace StoreOCP
{
    class VisaPayment : IPaymentMethod
    {
        public bool processPayment(double amount)
        {
            Console.WriteLine("Processing payment with Credit Card OCP");

            return true;
        }
    }
}
