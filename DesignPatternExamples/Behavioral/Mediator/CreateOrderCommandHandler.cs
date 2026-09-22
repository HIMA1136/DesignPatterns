namespace DesignPatternExamples.Mediator;

public class CreateOrderCommandHandler(OrderRepository repository) : IRequestHandler<CreateOrderCommand, Guid>
{
    public Guid Handle(CreateOrderCommand request)
    {
        var orderId = Guid.NewGuid();
        var order = new Order(orderId, request.CustomerName, request.ProductName, request.Amount);

        repository.Add(order);

        Console.WriteLine($"Command handled: created order {orderId} for {request.CustomerName}.");
        return orderId;
    }
}
