using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Decorator.Condiments
{
    class Whip : CondimentDecorator
    {
        Beverage _beverage;
        public Whip(Beverage Beverage)
        {
            _beverage = Beverage;
        }

        public override double Cost()
        {
            return 0.10 + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }
    }
}
