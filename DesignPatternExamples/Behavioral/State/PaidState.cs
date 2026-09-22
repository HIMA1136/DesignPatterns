namespace DesignPatternExamples.State;

public class PaidState : IOrderState
{
    public void Pay(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} is already paid.");
    }

    public void Ship(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} has been shipped.");
        order.SetState(new ShippedState());
    }

    public void Deliver(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} must be shipped before delivery.");
    }

    public void Cancel(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} was cancelled and refunded.");
        order.SetState(new CancelledState());
    }
}
