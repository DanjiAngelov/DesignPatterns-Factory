using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project49.Order
{
    public class Order
    {
        public List<Dish> Dishes = new List<Dish>();

        public double GetTotal()
        {
            return Dishes.Sum(d => d.Price);
        }
    }
}
