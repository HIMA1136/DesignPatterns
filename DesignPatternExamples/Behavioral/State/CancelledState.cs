namespace DesignPatternExamples.State;

public class CancelledState : IOrderState
{
    public void Pay(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} is cancelled and cannot be paid.");
    }

    public void Ship(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} is cancelled and cannot be shipped.");
    }

    public void Deliver(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} is cancelled and cannot be delivered.");
    }

    public void Cancel(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} is already cancelled.");
    }
}
