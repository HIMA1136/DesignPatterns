namespace DesignPatternExamples.Structural.Composite;

public interface IFileSystemItem
{
    void Display(string indent = "");
}

public sealed class FileItem(string name) : IFileSystemItem
{
    public void Display(string indent = "") => Console.WriteLine($"{indent}- {name}");
}

public sealed class FolderItem(string name) : IFileSystemItem
{
    private readonly List<IFileSystemItem> _items = [];
    public void Add(IFileSystemItem item) => _items.Add(item);
    public void Display(string indent = "")
    {
        Console.WriteLine($"{indent}+ {name}");
        foreach (var item in _items) item.Display(indent + "  ");
    }
}

public static class CompositeDemo
{
    public static void Run()
    {
        var root = new FolderItem("Documents");
        root.Add(new FileItem("readme.txt"));
        var photos = new FolderItem("Photos");
        photos.Add(new FileItem("holiday.jpg"));
        root.Add(photos);
        root.Display();
    }
}
