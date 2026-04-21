using System;

// Component
public interface ICoffee
{
    string GetDescription();
    double GetCost();
}

// Concrete Component
public class SimpleCoffee : ICoffee
{
    public string GetDescription() => "Simple coffee";
    public double GetCost() => 2.0;
}

// Base Decorator
public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }

    public virtual string GetDescription() => coffee.GetDescription();
    public virtual double GetCost() => coffee.GetCost();
}

// Concrete Decorators
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
        => coffee.GetDescription() + ", Milk";

    public override double GetCost()
        => coffee.GetCost() + 0.5;
}

public class SugarDecorator : CoffeeDecorator
{
    public SugarDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
        => coffee.GetDescription() + ", Sugar";

    public override double GetCost()
        => coffee.GetCost() + 0.2;
}

// Entry Point
class Program
{
    static void Main(string[] args)
    {
        ICoffee coffee = new SimpleCoffee();

        // Добавяме декоратори
        coffee = new MilkDecorator(coffee);
        coffee = new SugarDecorator(coffee);

        Console.WriteLine(coffee.GetDescription());
        Console.WriteLine("Cost: " + coffee.GetCost());
    }
}
