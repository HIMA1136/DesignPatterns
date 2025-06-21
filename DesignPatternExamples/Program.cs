using DesignPatternExamples.Observer.Entittes;
using DesignPatternExamples.Observer;
using DesignPatternExamples.Strategy.CheckoutStrategyManager;
using DesignPatternExamples.Strategy.Entities;
using DesignPatternExamples.Strategy.Strategy_Factory;

var eventManager = new MarketplaceEventManager();

var customer1 = new Customer("Ibrahim");
var customer2 = new Customer("Ahmed");
var seller = new Seller("Ali");

// Subscribe
eventManager.Subscribe(MarketplaceEvent.NewProduct, customer1);
eventManager.Subscribe(MarketplaceEvent.PriceDrop, customer2);
eventManager.Subscribe(MarketplaceEvent.FlashSale, seller);
eventManager.Subscribe(MarketplaceEvent.NewProduct, seller);

// Publish Events
eventManager.Publish(MarketplaceEvent.NewProduct, "New Phone released!");
eventManager.Publish(MarketplaceEvent.PriceDrop, "Price dropped on TV!");
eventManager.Publish(MarketplaceEvent.FlashSale, "2-Hour Flash Sale!");

// Unsubscribe
eventManager.Unsubscribe(MarketplaceEvent.NewProduct, seller);

Console.WriteLine("\nAfter unsubscription:\n");
eventManager.Publish(MarketplaceEvent.NewProduct, "New Tablet launched!");
////////////////////////////////////////////
/// ///////////////////////////////////////////
 Console.WriteLine("\n////StratgyPattern//////:\n");

var pricingType = PricingStrategyType.Premium;
var checkoutType = CheckoutStrategyType.CashOnDelivery;

var pricingStrategy = StrategyFactory.GetPricingStrategy(pricingType);
var checkoutStrategy = StrategyFactory.GetCheckoutStrategy(checkoutType);

var product = new Product("Smartphone", 1000, pricingStrategy);

var processor = new CheckoutProcessor(checkoutStrategy);
processor.Process(product);

