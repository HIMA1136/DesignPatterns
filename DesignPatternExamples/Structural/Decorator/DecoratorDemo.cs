namespace DesignPatternExamples.Structural.Decorator;

public interface ICoffee
{
    string Description { get; }
    decimal Cost { get; }
}

public sealed class HouseCoffee : ICoffee
{
    public string Description => "House coffee";
    public decimal Cost => 2.00m;
}

public sealed class MilkDecorator(ICoffee coffee) : ICoffee
{
    public string Description => $"{coffee.Description} with milk";
    public decimal Cost => coffee.Cost + 0.50m;
}

public static class DecoratorDemo
{
    public static void Run()
    {
        ICoffee coffee = new MilkDecorator(new HouseCoffee());
        Console.WriteLine($"{coffee.Description}: ${coffee.Cost:F2}");
    }
}
