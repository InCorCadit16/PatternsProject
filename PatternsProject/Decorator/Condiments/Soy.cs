using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Decorator.Condiments
{
    class Soy : CondimentDecorator
    {
        Beverage _beverage;
        public Soy(Beverage Beverage)
        {
            _beverage = Beverage;
        }

        public override double Cost()
        {
            return 0.15 + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }
    }
}
