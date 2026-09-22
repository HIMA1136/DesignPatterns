using DesignPatternExamples.Strategy.Entities;

namespace DesignPatternExamples.Strategy.PricingStrategyManager.PricingStrategies;
public class PremiumPricingStrategy: IPricingStrategy
{
    public decimal CalculatePrice(Product product) => product.BasePrice * 1.2m;
}
