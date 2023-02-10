using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            if (type == "cheese")
            {
                return new ChicagoStyleCheesePizza();
            }
            if (type == "veggie")
            {
                return new ChicagoStyleVeggiePizza();
            }
            return null;
        }
    }
}
