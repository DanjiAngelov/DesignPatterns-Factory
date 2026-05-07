using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project49.Dishes;

namespace Project49.Factory_Pattern
{
    public class DishFactory
    {
        public static Dish CreateDish(string type)
        {
            switch (type)
            {
                case "burger": return new Burger();
                default: throw new Exception("Невалиден тип");
            }
        }
    }
}
