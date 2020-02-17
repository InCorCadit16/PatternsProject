using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Decorator.Drinks
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _description = "House Blend";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
