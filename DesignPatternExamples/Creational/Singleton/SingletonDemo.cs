namespace DesignPatternExamples.Creational.Singleton;

public sealed class AppSettings
{
    private static readonly Lazy<AppSettings> LazyInstance = new(() => new AppSettings());
    public static AppSettings Instance => LazyInstance.Value;

    private AppSettings() { }

    public string ApplicationName { get; } = "Design Pattern Examples";
}

public static class SingletonDemo
{
    public static void Run()
    {
        var first = AppSettings.Instance;
        var second = AppSettings.Instance;
        Console.WriteLine($"Application: {first.ApplicationName}");
        Console.WriteLine($"Same instance: {ReferenceEquals(first, second)}");
    }
}
