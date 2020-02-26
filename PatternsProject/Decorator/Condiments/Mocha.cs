using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Decorator.Condiments
{
    class Mocha : CondimentDecorator
    {
        Beverage _beverage;
        public Mocha(Beverage Beverage)
        {
            _beverage = Beverage;
        }

        public override double Cost()
        {
            return 0.20 + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }
    }
}
