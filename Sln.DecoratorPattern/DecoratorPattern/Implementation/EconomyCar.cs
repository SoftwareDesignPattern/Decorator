using DecoratorPattern.Interface;

namespace DecoratorPattern.Implementation
{
    public class EconomyCar : ICar
    {
        public string GetDescription()
        {
            return "Economy Car";
        }

        public double GetCost()
        {
            return 950000;
        }
    }
}
