using DesignPatternExamples.Observer.Entittes;
using DesignPatternExamples.Observer;

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
