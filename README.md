# Decorator
* The Decorator design pattern seeks to add new functionality to an existing object 
without changing that object's definition.

```C#
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
```


### Advantages of Decorator Pattern
* Adds functionality to existing objects dynamically
* Alternative to sub classing
* Flexible design
* Supports Open Closed Principle
### When to use Decorator Pattern
* Legacy System
* Contorls
* Sealed Classes

### Abstract
* An abstract function cannot have functionality. 
You're basically saying, any child class MUST give their 
own version of this method, however it's too general to even try to implement in the parent class.

### Virtual
* A virtual function, is basically saying look, here's the functionality 
that may or may not be good enough for the child class. 
So if it is good enough, use this method, if not, 
then override me, and provide your own functionality.