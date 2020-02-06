using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus_Lab_Bill_Inheritance_Challenge
{
    class Bill
    {
        public double Subtotal { get; set; }
        public double TaxRate { get; set; }

        public Bill()
        {

        }

        public Bill(double _subtotal, double _taxRate)
        {
            Subtotal = _subtotal;
            TaxRate = _taxRate;
        }

        public virtual double CalcTotal()
        {
            return (Subtotal * (1 + TaxRate));
        }

    }
}
