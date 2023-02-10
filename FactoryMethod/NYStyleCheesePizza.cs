using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style Sauce and Cheese Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
