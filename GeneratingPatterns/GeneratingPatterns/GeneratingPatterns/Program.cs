using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratingPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            IClonable clonableClass = new ClonableClass() { Name = "Daniil" };
            IClonable clonableClass1 = clonableClass.Clone();
            clonableClass1.Name = "Oleg";
            
            Console.WriteLine(clonableClass.Name);
            Console.WriteLine(clonableClass1.Name);
            Console.WriteLine();

            IBuilder builder = new Builder();
            Director director = new Director(builder);
            Pizza pizza = director.Create();
            
            
            foreach (string item in pizza.parts)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            
            RussiaFoodFactory russiaFoodFactory = new RussiaFoodFactory();
            AmericanFoodFactory americanFoodFactory = new AmericanFoodFactory();
            IBurger americanBurger = americanFoodFactory.CreateBurger();
            IPizza russiaPizza = russiaFoodFactory.CreatePizza();
            Console.WriteLine($"{americanBurger} {russiaPizza}");
            Console.WriteLine();

            Singleton singleton = Singleton.Instance();
            Singleton singleto1 = Singleton.Instance();
            Console.WriteLine(singleton.GetHashCode() == singleto1.GetHashCode());
            Console.WriteLine();

            ProductA_Creator productA_Creator = new ProductA_Creator();
            ProductB_Creator productB_Creator = new ProductB_Creator();
            IProduct productA = productA_Creator.Create();
            IProduct productB = productB_Creator.Create();
            
            Console.WriteLine($"{productA} {productB}");

            Console.ReadLine();
        }
    }

}
