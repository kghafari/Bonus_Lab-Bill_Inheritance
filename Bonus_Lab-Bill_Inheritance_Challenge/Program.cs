using System;

namespace Bonus_Lab_Bill_Inheritance_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Bill bill = new Bill(15.80, 0.06);
            Pay(bill);

            TippableBill tipBill = new TippableBill(8.50, 0.06, 2.00);
            Pay(tipBill);
        }

        public static void Pay(Bill bill)
        {
            double total = bill.CalcTotal();
            Console.WriteLine($"${total}");
        }
    }
}
