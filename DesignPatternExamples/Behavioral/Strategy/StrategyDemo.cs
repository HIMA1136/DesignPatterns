using DesignPatternExamples.Observer.Entittes;
using DesignPatternExamples.Observer;
using DesignPatternExamples.Strategy.CheckoutStrategyManager;
using DesignPatternExamples.Strategy.Entities;
using DesignPatternExamples.Strategy.Strategy_Factory;
using DesignPatternExamples.Strategy.PricingStrategyManager;
using System.Diagnostics;

namespace DesignPatternExamples.Strategy
{
    public static class StrategyDemo
    {
        public static void Run()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n--- Strategy Pattern Example ---");
            Console.ResetColor();

            var pricingType1 = PricingStrategyType.Premium;
            var checkoutType1 = CheckoutStrategyType.CashOnDelivery;

            var pricingType2 = PricingStrategyType.Discount;
            var checkoutType2 = CheckoutStrategyType.CashOnDelivery;

            var pricingType3 = PricingStrategyType.Regular;
            var checkoutType3 = CheckoutStrategyType.CashOnDelivery;

            var pricingStrategy1 = StrategyFactory.GetPricingStrategy(pricingType1);
            var checkoutStrategy1 = StrategyFactory.GetCheckoutStrategy(checkoutType1);

            var pricingStrategy2 = StrategyFactory.GetPricingStrategy(pricingType2);
            var checkoutStrategy2 = StrategyFactory.GetCheckoutStrategy(checkoutType2);

            var pricingStrategy3 = StrategyFactory.GetPricingStrategy(pricingType3);
            var checkoutStrategy3 = StrategyFactory.GetCheckoutStrategy(checkoutType3);

            var product1 = new Product("Smartphone1", 1000, pricingStrategy1);
            var product2 = new Product("Smartphone2", 1000, pricingStrategy2);
            var product3 = new Product("Smartphone3", 1000, pricingStrategy3);


            var processor1 = new CheckoutProcessor(checkoutStrategy1);
            var processor2 = new CheckoutProcessor(checkoutStrategy2);
            var processor3 = new CheckoutProcessor(checkoutStrategy3);

            processor1.Process(product1);
            processor2.Process(product2);
            processor3.Process(product3);

        }
    }
}
