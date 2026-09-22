namespace DesignPatternExamples.State;

public interface IOrderState
{
    void Pay(OrderContext order);
    void Ship(OrderContext order);
    void Deliver(OrderContext order);
    void Cancel(OrderContext order);
}
