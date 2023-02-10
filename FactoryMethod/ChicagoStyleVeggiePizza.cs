using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Chicago Style Veggie Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomate sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }
    }
}
