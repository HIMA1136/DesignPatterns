using DesignPatternExamples.Strategy.CheckoutStrategyManager.CheckoutStrategies;
using DesignPatternExamples.Strategy.CheckoutStrategyManager;
using DesignPatternExamples.Strategy.Entities;
using DesignPatternExamples.Strategy.PricingStrategyManager.PricingStrategies;
using DesignPatternExamples.Strategy.PricingStrategyManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples.Strategy.Strategy_Factory;

public static class StrategyFactory
{
    public static IPricingStrategy GetPricingStrategy(PricingStrategyType type) => type switch
    {
        PricingStrategyType.Regular => new RegularPricingStrategy(),
        PricingStrategyType.Discount => new DiscountPricingStrategy(),
        PricingStrategyType.Premium => new PremiumPricingStrategy(),
        _ => throw new NotImplementedException()
    };

    public static ICheckoutStrategy GetCheckoutStrategy(CheckoutStrategyType type) => type switch
    {
        CheckoutStrategyType.Online => new OnlineCheckoutStrategy(),
        CheckoutStrategyType.CashOnDelivery => new CashOnDeliveryStrategy(),
        CheckoutStrategyType.InStore => new InStoreCheckoutStrategy(),
        _ => throw new NotImplementedException()
    };
}
