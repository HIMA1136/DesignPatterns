namespace DesignPatternExamples.Observer.Entittes;
public class Seller(string name) : ISubscriber
{
    public string Name { get; } = name;

    public void Notify(MarketplaceEvent eventType, string message)
    {
        Console.WriteLine($"[Seller: {Name}] Event: {eventType}, Message: {message}");
    }
}
