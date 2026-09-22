namespace DesignPatternExamples.Mediator;

public class GetOrderByIdQueryHandler(OrderRepository repository) : IRequestHandler<GetOrderByIdQuery, OrderDto?>
{
    public OrderDto? Handle(GetOrderByIdQuery request)
    {
        var order = repository.GetById(request.OrderId);

        if (order is null)
        {
            Console.WriteLine($"Query handled: order {request.OrderId} was not found.");
            return null;
        }

        Console.WriteLine($"Query handled: fetched order {request.OrderId}.");
        return new OrderDto(order.Id, order.CustomerName, order.ProductName, order.Amount);
    }
}
