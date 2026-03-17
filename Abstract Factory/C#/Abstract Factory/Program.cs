using System;

// Abstract Products
public interface IButton
{
    void Render();
}

public interface ICheckbox
{
    void Check();
}

// Concrete Products - Light Theme
public class LightButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Light Button");
    }
}

public class LightCheckbox : ICheckbox
{
    public void Check()
    {
        Console.WriteLine("Checking Light Checkbox");
    }
}

// Concrete Products - Dark Theme
public class DarkButton : IButton
{
    public void Render()
    {
        Console.WriteLine("Rendering Dark Button");
    }
}

public class DarkCheckbox : ICheckbox
{
    public void Check()
    {
        Console.WriteLine("Checking Dark Checkbox");
    }
}

// Abstract Factory
public interface IGUIFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}

// Concrete Factories
public class LightFactory : IGUIFactory
{
    public IButton CreateButton() => new LightButton();
    public ICheckbox CreateCheckbox() => new LightCheckbox();
}

public class DarkFactory : IGUIFactory
{
    public IButton CreateButton() => new DarkButton();
    public ICheckbox CreateCheckbox() => new DarkCheckbox();
}

// Client
class Program
{
    static void Main()
    {
        IGUIFactory factory = new DarkFactory();

        IButton button = factory.CreateButton();
        ICheckbox checkbox = factory.CreateCheckbox();

        button.Render();
        checkbox.Check();
    }
}