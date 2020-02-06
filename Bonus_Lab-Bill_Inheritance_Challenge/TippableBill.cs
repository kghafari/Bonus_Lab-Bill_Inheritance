using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus_Lab_Bill_Inheritance_Challenge
{
    class TippableBill : Bill
    {
        public double Tip { get; set; }

        public TippableBill()
        {

        }
        public TippableBill(double _subtotal, double _taxRate, double _tip)
        {
            Subtotal = _subtotal;
            TaxRate = _taxRate;
            Tip = _tip;
        }

        public override double CalcTotal()
        {
            double bill = base.CalcTotal();
            return bill + Tip;
               
        }
    }
}
