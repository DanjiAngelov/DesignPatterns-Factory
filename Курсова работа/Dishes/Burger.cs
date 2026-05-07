using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project49.Dishes
{
    public class Burger : Dish
    {
        public Burger()
        {
            Name = "Бургер";
            Price = 5.00;
        }

        public override string GetDescription()
        {
            return "Бургер с месо, хляб и зеленчуци";
        }
    }
}
