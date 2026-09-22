namespace DesignPatternExamples.State;

public class DeliveredState : IOrderState
{
    public void Pay(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} is already completed.");
    }

    public void Ship(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} is already delivered.");
    }

    public void Deliver(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} has already been delivered.");
    }

    public void Cancel(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} cannot be cancelled after delivery.");
    }
}
