using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();

            Pizza Npizza = nyStore.orderPizza("cheese");

            Console.WriteLine("Kayle order a " + Npizza.getName() + "\n");

            PizzaStore ChicagoStore = new ChicagoPizzaStore();

            Pizza Cpizza = ChicagoStore.orderPizza("cheese");

            Console.WriteLine("Kayle order a " + Cpizza.getName() + "\n");
        }
    }
}
