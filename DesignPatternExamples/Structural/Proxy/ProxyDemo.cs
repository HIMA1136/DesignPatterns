namespace DesignPatternExamples.Structural.Proxy;

public interface IImage
{
    void Display();
}

public sealed class RealImage(string fileName) : IImage
{
    public void Display() => Console.WriteLine($"Displaying {fileName}.");
}

public sealed class ProtectedImageProxy(string fileName, bool hasAccess) : IImage
{
    public void Display()
    {
        if (!hasAccess)
        {
            Console.WriteLine("Access denied.");
            return;
        }

        new RealImage(fileName).Display();
    }
}

public static class ProxyDemo
{
    public static void Run()
    {
        new ProtectedImageProxy("confidential.png", false).Display();
        new ProtectedImageProxy("confidential.png", true).Display();
    }
}
