using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Decorator.Drinks
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            _description = "Decaf";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
