using DesignPatternExamples.Strategy.Entities;

namespace DesignPatternExamples.Strategy.PricingStrategyManager.PricingStrategies;

public class DiscountPricingStrategy:IPricingStrategy
{
    public decimal CalculatePrice(Product product) => product.BasePrice * 0.9m;
}
