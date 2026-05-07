using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project49.Strategy_Pattern
{
    public interface IDiscountStrategy
    {
        double ApplyDiscount(double price);
    }
}
