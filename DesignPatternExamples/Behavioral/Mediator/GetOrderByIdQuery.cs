namespace DesignPatternExamples.Mediator;

public class GetOrderByIdQuery(Guid orderId) : IRequest<OrderDto?>
{
    public Guid OrderId { get; } = orderId;
}
