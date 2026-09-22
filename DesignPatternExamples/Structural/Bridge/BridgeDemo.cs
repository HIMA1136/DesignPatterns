namespace DesignPatternExamples.Structural.Bridge;

public interface IDevice
{
    void SetChannel(int channel);
}

public sealed class Television : IDevice
{
    public void SetChannel(int channel) => Console.WriteLine($"TV switched to channel {channel}.");
}

public sealed class Radio : IDevice
{
    public void SetChannel(int channel) => Console.WriteLine($"Radio tuned to station {channel}.");
}

public sealed class Remote(IDevice device)
{
    public void SelectChannel(int channel) => device.SetChannel(channel);
}

public static class BridgeDemo
{
    public static void Run()
    {
        new Remote(new Television()).SelectChannel(7);
        new Remote(new Radio()).SelectChannel(101);
    }
}
