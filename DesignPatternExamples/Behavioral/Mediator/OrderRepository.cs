namespace DesignPatternExamples.Mediator;

public class OrderRepository
{
    private readonly Dictionary<Guid, Order> _orders = new();

    public void Add(Order order)
    {
        _orders[order.Id] = order;
    }

    public Order? GetById(Guid orderId)
    {
        return _orders.TryGetValue(orderId, out var order) ? order : null;
    }
}
