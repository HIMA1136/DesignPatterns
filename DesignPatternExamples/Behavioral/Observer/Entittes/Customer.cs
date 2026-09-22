namespace DesignPatternExamples.Observer.Entittes;
public class Customer(string name) : ISubscriber
{
    public string Name { get; } = name;

    public void Notify(MarketplaceEvent eventType, string message)
    {
        Console.WriteLine($"[Customer: {Name}] Event: {eventType}, Message: {message}");
    }
}
