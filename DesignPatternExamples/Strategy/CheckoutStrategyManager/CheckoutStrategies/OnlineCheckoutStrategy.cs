using DesignPatternExamples.Strategy.Entities;

namespace DesignPatternExamples.Strategy.CheckoutStrategyManager.CheckoutStrategies;
public class OnlineCheckoutStrategy: ICheckoutStrategy
{
    public void Checkout(
        Product product,
        decimal price)
    {
        Console.WriteLine($"Online checkout: {product.Name} - {price:C}");
    }
}
