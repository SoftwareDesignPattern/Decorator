using DecoratorPattern.AbstractDecorator;
using DecoratorPattern.Interface;

namespace DecoratorPattern.ConcreteDecorator
{
    public class AdvancedAccessories : CarAccessoriesDecorator
    {
        public AdvancedAccessories(ICar Car) : base(Car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() + ",Advanced Accessories Package";
        }

        public override double GetCost()
        {
            return base.GetCost() + 10000.0;
        }
    }

}
