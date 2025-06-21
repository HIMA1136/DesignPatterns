using DesignPatternExamples.Strategy.Entities;

namespace DesignPatternExamples.Strategy.PricingStrategyManager.PricingStrategies;
public class RegularPricingStrategy: IPricingStrategy
{ 
    public decimal CalculatePrice(Product product) => product.BasePrice;
}
