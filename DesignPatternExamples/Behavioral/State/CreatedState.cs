namespace DesignPatternExamples.State;

public class CreatedState : IOrderState
{
    public void Pay(OrderContext order)
    {
        Console.WriteLine($"Payment received for order {order.OrderNumber}.");
        order.SetState(new PaidState());
    }

    public void Ship(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} must be paid before shipping.");
    }

    public void Deliver(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} cannot be delivered before shipping.");
    }

    public void Cancel(OrderContext order)
    {
        Console.WriteLine($"Order {order.OrderNumber} was cancelled before payment.");
        order.SetState(new CancelledState());
    }
}
