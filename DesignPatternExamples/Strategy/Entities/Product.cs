using DesignPatternExamples.Strategy.PricingStrategyManager;

namespace DesignPatternExamples.Strategy.Entities;

public class Product(
    string name,
    decimal basePrice,
    IPricingStrategy pricingStrategy)
{
    public string Name { get; } = name;
    public decimal BasePrice { get; } = basePrice;

    public decimal GetPrice() => pricingStrategy.CalculatePrice(this);
}
