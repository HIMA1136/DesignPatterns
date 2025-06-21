using DesignPatternExamples.Strategy.Entities;

namespace DesignPatternExamples.Strategy.CheckoutStrategyManager.CheckoutStrategies;
public class InStoreCheckoutStrategy: ICheckoutStrategy
{
    public void Checkout(
        Product product,
        decimal price)
    {
        Console.WriteLine($"In-store purchase: {product.Name} - {price:C}");
    }
}
