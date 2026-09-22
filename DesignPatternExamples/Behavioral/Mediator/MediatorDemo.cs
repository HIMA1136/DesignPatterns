namespace DesignPatternExamples.Mediator;

public static class MediatorDemo
{
    public static void Run()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n--- Mediator Pattern Example (CQRS Style) ---");
        Console.ResetColor();

        var repository = new OrderRepository();
        var mediator = new SimpleMediator();

        mediator.RegisterHandler(new CreateOrderCommandHandler(repository));
        mediator.RegisterHandler(new GetOrderByIdQueryHandler(repository));

        Console.WriteLine("Sending command through mediator...");
        var orderId = mediator.Send(new CreateOrderCommand("Ibrahim", "Laptop", 1850m));

        Console.WriteLine("\nSending query through mediator...");
        var order = mediator.Send(new GetOrderByIdQuery(orderId));

        if (order is not null)
        {
            Console.WriteLine($"Order Result => Id: {order.Id}, Customer: {order.CustomerName}, Product: {order.ProductName}, Amount: {order.Amount}");
        }

        Console.WriteLine("\nSending query for missing order...");
        mediator.Send(new GetOrderByIdQuery(Guid.NewGuid()));
    }
}
