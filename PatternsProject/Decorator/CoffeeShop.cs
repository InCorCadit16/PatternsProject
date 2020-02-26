using System;
using System.Collections.Generic;
using System.Text;
using PatternsProject.Decorator.Condiments;
using PatternsProject.Decorator.Drinks;


namespace PatternsProject.Decorator
{
    class CoffeeShop
    {
        static void Main(string[] args)
        {
            Beverage beverage = new HouseBlend();

            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);
            Console.WriteLine($"{beverage.GetDescription()} - {beverage.Cost()}");

            beverage = new DarkRoast();

            beverage = new Soy(beverage);
            beverage = new Whip(beverage);
            beverage = new Mocha(beverage);
            Console.WriteLine($"{beverage.GetDescription()} - {beverage.Cost()}");
        }
    }
}
