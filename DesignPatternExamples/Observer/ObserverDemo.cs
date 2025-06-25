using DesignPatternExamples.Observer.Entittes;

namespace DesignPatternExamples.Observer
{
    public static class ObserverDemo
    {
        public static void Run()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n--- Observer Pattern Example ---");
            Console.ResetColor();

            var eventManager = new MarketplaceEventManager();

            var customer1 = new Customer("Ibrahim");
            var customer2 = new Customer("Ahmed");
            var seller = new Seller("Ali");

            eventManager.Subscribe(MarketplaceEvent.NewProduct, customer1);
            eventManager.Subscribe(MarketplaceEvent.PriceDrop, customer2);
            eventManager.Subscribe(MarketplaceEvent.FlashSale, seller);
            eventManager.Subscribe(MarketplaceEvent.NewProduct, seller);

            eventManager.Publish(MarketplaceEvent.NewProduct, "New Phone released!");
            eventManager.Publish(MarketplaceEvent.PriceDrop, "Price dropped on TV!");
            eventManager.Publish(MarketplaceEvent.FlashSale, "2-Hour Flash Sale!");

            eventManager.Unsubscribe(MarketplaceEvent.NewProduct, seller);

            Console.WriteLine("\nAfter unsubscription:");
            eventManager.Publish(MarketplaceEvent.NewProduct, "New Tablet launched!");
        }
    }
}
