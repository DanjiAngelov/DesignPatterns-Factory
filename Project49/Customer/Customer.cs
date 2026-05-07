using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project49.Strategy_Pattern;

namespace Project49.Customer
{
    public class Customer
    {
        public string Name { get; set; }
        public IDiscountStrategy DiscountStrategy { get; set; }

        public double ApplyDiscount(double price)
        {
            return DiscountStrategy.ApplyDiscount(price);
        }
    }
}
