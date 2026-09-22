namespace DesignPatternExamples.State;

public static class StateDemo
{
    public static void Run()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n--- State Pattern Example ---");
        Console.ResetColor();

        var firstOrder = new OrderContext("ORD-1001");
        Console.WriteLine($"Order {firstOrder.OrderNumber} starts in {firstOrder.CurrentState} state.");
        firstOrder.Ship();
        firstOrder.Pay();
        firstOrder.Ship();
        firstOrder.Deliver();
        firstOrder.Cancel();

        Console.WriteLine();

        var secondOrder = new OrderContext("ORD-1002");
        Console.WriteLine($"Order {secondOrder.OrderNumber} starts in {secondOrder.CurrentState} state.");
        secondOrder.Cancel();
        secondOrder.Pay();
    }
}
