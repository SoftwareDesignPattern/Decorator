using DecoratorPattern.AbstractDecorator;
using DecoratorPattern.Interface;

namespace DecoratorPattern.ConcreteDecorator
{
    public class BasicAccessories : CarAccessoriesDecorator
    {
        public BasicAccessories(ICar Car) : base(Car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",Basic Accessories Package";

        }

        public override double GetCost()
        {
            return base.GetCost() + 2000.0;
        }
    }
}
