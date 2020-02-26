using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Decorator
{
    abstract class Beverage
    {
        protected string _description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return _description;
        }

        public abstract double Cost();
    }
}
