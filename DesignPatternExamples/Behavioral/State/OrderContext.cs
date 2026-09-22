namespace DesignPatternExamples.State;

public class OrderContext
{
    private IOrderState _state;

    public OrderContext(string orderNumber)
    {
        OrderNumber = orderNumber;
        _state = new CreatedState();
    }

    public string OrderNumber { get; }

    public string CurrentState => _state.GetType().Name.Replace("State", string.Empty);

    public void SetState(IOrderState state)
    {
        _state = state;
        Console.WriteLine($"Order {OrderNumber} moved to {CurrentState} state.");
    }

    public void Pay() => _state.Pay(this);

    public void Ship() => _state.Ship(this);

    public void Deliver() => _state.Deliver(this);

    public void Cancel() => _state.Cancel(this);
}
