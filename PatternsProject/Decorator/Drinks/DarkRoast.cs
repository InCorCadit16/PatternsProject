﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsProject.Decorator.Drinks
{
    class DarkRoast:Beverage
    {
        public DarkRoast()
        {
            _description = "Dark Roast";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}
