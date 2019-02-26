﻿using DecoratorPattern.Interface;

namespace DecoratorPattern.Implementation
{
    public class LuxuryCar : ICar
    {
        public string GetDescription()
        {
            return "Luxury Car";
        }

        public double GetCost()
        {
            return 29500000;
        }
    }
}
