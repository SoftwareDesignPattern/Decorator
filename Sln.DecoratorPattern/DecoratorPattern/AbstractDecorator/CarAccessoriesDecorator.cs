using DecoratorPattern.Interface;

namespace DecoratorPattern.AbstractDecorator
{
    public abstract class CarAccessoriesDecorator : ICar
    {
        private ICar _Car;
        public CarAccessoriesDecorator(ICar Car)
        {
            _Car = Car;
        }
        public virtual string GetDescription()
        {
            return _Car.GetDescription();
        }

        public virtual double GetCost()
        {
            return _Car.GetCost();
        }
    }
}
