using System;
using System.Collections.Generic;
using System.Text;

namespace StoreOCP
{
    class OrderOCP
    {
        private int id;
        private string name;
        private double amount;
        private bool paid;

        public OrderOCP(int id, String name, double amount)
        {
            this.id = id;
            this.name = name;
            this.amount = amount;
            paid = false;
        }

        public void ProcessOrder(PaymentMethod pm)
        {
            pm(amount);
        }


    }
}
