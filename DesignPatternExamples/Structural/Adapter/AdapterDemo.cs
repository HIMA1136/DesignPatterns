namespace DesignPatternExamples.Structural.Adapter;

public interface IModernPayment
{
    void Pay(decimal amount);
}

public sealed class LegacyPaymentGateway
{
    public void MakePayment(double amount) => Console.WriteLine($"Legacy gateway charged ${amount:F2}.");
}

public sealed class PaymentAdapter(LegacyPaymentGateway gateway) : IModernPayment
{
    public void Pay(decimal amount) => gateway.MakePayment((double)amount);
}

public static class AdapterDemo
{
    public static void Run() => new PaymentAdapter(new LegacyPaymentGateway()).Pay(42.50m);
}
