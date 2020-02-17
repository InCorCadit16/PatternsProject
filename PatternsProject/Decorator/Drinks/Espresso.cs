using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Decorator.Drinks
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            _description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
