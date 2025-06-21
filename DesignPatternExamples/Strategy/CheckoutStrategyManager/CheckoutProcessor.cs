using DesignPatternExamples.Strategy.Entities;

namespace DesignPatternExamples.Strategy.CheckoutStrategyManager;

public class CheckoutProcessor(ICheckoutStrategy checkoutStrategy)
{
    public void Process(Product product)
    {
        var price = product.GetPrice();
        checkoutStrategy.Checkout(product, price);
    }
}

