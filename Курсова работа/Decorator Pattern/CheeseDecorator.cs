using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project49.Decorator_Pattern
{
    public class CheeseDecorator : DishDecorator
    {
        public CheeseDecorator(Dish dish) : base(dish) { }

        public override string GetDescription()
        {
            return dish.GetDescription() + ", сирене";
        }

        public override double Price => dish.Price + 1.00;
    }
}
