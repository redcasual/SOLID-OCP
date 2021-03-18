using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace StoreOCP
{
    interface IPaymentMethod
    {
        bool processPayment(double amount);
    }
}
