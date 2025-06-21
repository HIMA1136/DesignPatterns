using DesignPatternExamples.Strategy.Entities;

namespace DesignPatternExamples.Strategy.CheckoutStrategyManager.CheckoutStrategies;
public class CashOnDeliveryStrategy : ICheckoutStrategy
{
    public void Checkout(
        Product product,
        decimal price)
    {
        Console.WriteLine($"Cash on delivery: {product.Name} - {price:C}");
    }
}
