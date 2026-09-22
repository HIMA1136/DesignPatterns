namespace DesignPatternExamples.Structural.Flyweight;

public sealed class TreeType(string name, string color)
{
    public void Display(int x, int y) => Console.WriteLine($"{name} ({color}) tree at {x},{y}.");
}

public static class TreeFactory
{
    private static readonly Dictionary<(string Name, string Color), TreeType> Types = [];
    public static TreeType Get(string name, string color)
    {
        var key = (name, color);
        if (!Types.TryGetValue(key, out var type)) Types[key] = type = new TreeType(name, color);
        return type;
    }
}

public static class FlyweightDemo
{
    public static void Run()
    {
        var oak1 = TreeFactory.Get("Oak", "Green");
        var oak2 = TreeFactory.Get("Oak", "Green");
        oak1.Display(2, 4);
        oak2.Display(8, 9);
        Console.WriteLine($"Shared tree data: {ReferenceEquals(oak1, oak2)}");
    }
}
