using DecoratorPattern.Interface;

namespace DecoratorPattern.Implementation
{
    public class DeluxCar : ICar
    {
        public string GetDescription()
        {
            return "Delux Car";
        }

        public double GetCost()
        {
            return 1950000;
        }
    }
}
