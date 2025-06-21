using DesignPatternExamples.Strategy.Entities;

namespace DesignPatternExamples.Strategy.PricingStrategyManager;

public interface IPricingStrategy
{
    decimal CalculatePrice(Product product);
}