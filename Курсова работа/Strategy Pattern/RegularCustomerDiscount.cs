using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project49.Strategy_Pattern
{
    public class RegularCustomerDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double price)
        {
            return price * 0.9;
        }
    }
}
