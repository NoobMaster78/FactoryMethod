using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            name = "NY Style Veggie Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinada Sauce";

            toppings.Add("Grated Reggeiano Chease");
        }
    }
}
