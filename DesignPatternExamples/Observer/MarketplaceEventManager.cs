using DesignPatternExamples.Observer.Entittes;

namespace DesignPatternExamples.Observer;
public class MarketplaceEventManager
{
    private readonly Dictionary<MarketplaceEvent, List<ISubscriber>> _subscribers = new();

    public void Subscribe(MarketplaceEvent eventType, ISubscriber subscriber)
    {
        if (!_subscribers.ContainsKey(eventType))
            _subscribers[eventType] = new List<ISubscriber>();

        _subscribers[eventType].Add(subscriber);
    }

    public void Unsubscribe(MarketplaceEvent eventType, ISubscriber subscriber)
    {
        if (_subscribers.ContainsKey(eventType))
            _subscribers[eventType].Remove(subscriber);
    }

    public void Publish(MarketplaceEvent eventType, string message)
    {
        if (_subscribers.TryGetValue(eventType, out var list))
        {
            foreach (var subscriber in list)
            {
                subscriber.Notify(eventType, message);
            }
        }
    }
}

