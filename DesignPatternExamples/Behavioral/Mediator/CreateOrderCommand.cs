namespace DesignPatternExamples.Mediator;

public class CreateOrderCommand(string customerName, string productName, decimal amount) : IRequest<Guid>
{
    public string CustomerName { get; } = customerName;
    public string ProductName { get; } = productName;
    public decimal Amount { get; } = amount;
}
