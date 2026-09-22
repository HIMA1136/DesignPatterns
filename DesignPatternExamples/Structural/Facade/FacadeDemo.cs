namespace DesignPatternExamples.Structural.Facade;

public sealed class InventoryService { public void Reserve() => Console.WriteLine("Inventory reserved."); }
public sealed class PaymentService { public void Charge() => Console.WriteLine("Payment processed."); }
public sealed class ShippingService { public void Ship() => Console.WriteLine("Order shipped."); }

public sealed class OrderFacade
{
    private readonly InventoryService _inventory = new();
    private readonly PaymentService _payment = new();
    private readonly ShippingService _shipping = new();
    public void PlaceOrder()
    {
        _inventory.Reserve();
        _payment.Charge();
        _shipping.Ship();
    }
}

public static class FacadeDemo
{
    public static void Run() => new OrderFacade().PlaceOrder();
}
