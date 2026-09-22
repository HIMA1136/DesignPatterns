using DesignPatternExamples.Observer.Entittes;

namespace DesignPatternExamples.Observer;
public interface ISubscriber
{
    void Notify(
        MarketplaceEvent eventType,
        string message);
    string Name { get; }
}
