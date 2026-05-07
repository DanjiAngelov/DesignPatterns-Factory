using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project49.Decorator_Pattern
{
    public abstract class DishDecorator : Dish
    {
        protected Dish dish;

        public DishDecorator(Dish dish)
        {
            this.dish = dish;
        }
    }
}
