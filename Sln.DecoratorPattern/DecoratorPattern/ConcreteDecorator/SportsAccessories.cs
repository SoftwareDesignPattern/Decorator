using DecoratorPattern.AbstractDecorator;
using DecoratorPattern.Interface;

namespace DecoratorPattern.ConcreteDecorator
{
    public class SportsAccessories : CarAccessoriesDecorator
    {
        public SportsAccessories(ICar Car) : base(Car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",Sports Accessories Package";
        }

        public override double GetCost()
        {
            return base.GetCost() + 15000.0;
        }
    }
}
