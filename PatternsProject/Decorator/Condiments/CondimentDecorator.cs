using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Decorator.Condiments
{
    abstract class CondimentDecorator : Beverage
    {
        public abstract string GetDescription();

    }
}
