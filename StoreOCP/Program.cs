using System;

namespace StoreOCP
{
    public delegate bool PaymentMethod(double amount);

    class Program
    {
        static void Main(string[] args)
        {
            OrderOCP orderOPC = new OrderOCP(1, "Headphones", 35.99);

            Console.WriteLine("*** Open Close Principle ***");
            Console.WriteLine();
            Console.WriteLine("  Select Method of Payment");
            Console.WriteLine("  1- Cash");
            Console.WriteLine("  2- Credit Card");
            int op = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case 1:
                    orderOPC.ProcessOrder(CashPayment.processPaymentD);
                    orderOPC.ProcessOrder(new CashPayment().processPayment);
                    break;
                case 2:
                    orderOPC.ProcessOrder(new VisaPayment().processPayment);
                    break;
                default:
                    Console.WriteLine("Payment Method Not Accepted");
                    break;
            }

            Console.ReadLine();
        }
    }
}
