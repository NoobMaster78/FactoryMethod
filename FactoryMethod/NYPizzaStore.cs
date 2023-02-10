using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class NYPizzaStore : PizzaStore
    {

        protected override Pizza createPizza(string type)
        {
            if (type == "cheese")
            {
                return new NYStyleCheesePizza();
            }
            if (type == "veggie")
            {
                return new NYStyleVeggiePizza();
            }
            return null;
        }
    }
}
