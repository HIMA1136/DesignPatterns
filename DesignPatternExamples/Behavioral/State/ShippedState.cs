namespace DesignPatternExamples.State;

public class ShippedState : IOrderState
{
    public void Pay(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} is already paid and shipped.");
    }

    public void Ship(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} is already on the way.");
    }

    public void Deliver(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} has been delivered.");
        order.SetState(new DeliveredState());
    }

    public void Cancel(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} cannot be cancelled after shipping.");
    }
}
