using DesignPatternExamples.Strategy.Entities;

namespace DesignPatternExamples.Strategy.CheckoutStrategyManager;

public interface ICheckoutStrategy
{
    void Checkout(
        Product product,
        decimal price);
}
