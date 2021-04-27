using System;
using System.Collections.Generic;
using System.Text;

namespace TaxApp
{
    class TaxClass
    {
     
        public double totalAmount;
        public double tax_rate = 0.85;
        public double GetTotalAmount()
        {
            return totalAmount;
        }

        public double GetTax(double amount)
        {
            double getTax = amount - (amount * tax_rate);
            return getTax;
        }

    }
}
