namespace DesignPatternExamples.Mediator;

public class OrderDto(Guid id, string customerName, string productName, decimal amount)
{
    public Guid Id { get; } = id;
    public string CustomerName { get; } = customerName;
    public string ProductName { get; } = productName;
    public decimal Amount { get; } = amount;
}
