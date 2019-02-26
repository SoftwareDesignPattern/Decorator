using DecoratorPattern.AbstractDecorator;
using DecoratorPattern.ConcreteDecorator;
using DecoratorPattern.Implementation;
using DecoratorPattern.Interface;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create EcomomyCar instance.
            ICar car = new EconomyCar();

            //Wrp EconomyCar instancw with BasicAccessories.
            CarAccessoriesDecorator carAccessoriesDecorator = new BasicAccessories(car);

            //Wrap EconomyCar instance with AdvancedAccessories instance.
            carAccessoriesDecorator = new AdvancedAccessories(carAccessoriesDecorator);

            Console.WriteLine("Car Detials: " + carAccessoriesDecorator.GetDescription());
            Console.WriteLine("Total Price: " + carAccessoriesDecorator.GetCost());

            Console.ReadLine();
        }
    }
}
