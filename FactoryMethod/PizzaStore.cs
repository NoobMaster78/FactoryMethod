using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class PizzaStore
    {
        public virtual Pizza orderPizza(string type)
        {
            Pizza pizza = createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        /// <summary>
        /// Creates the pizza.
        /// </summary>
        /// <param name="type"> Название требуемой пиццы </param>
        /// <returns></returns>
        
        protected abstract Pizza createPizza(string type);
    }
}
