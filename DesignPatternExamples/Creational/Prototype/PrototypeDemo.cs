namespace DesignPatternExamples.Creational.Prototype;

public sealed class Document(string title, List<string> sections)
{
    public string Title { get; set; } = title;
    public List<string> Sections { get; } = sections;

    public Document Clone() => new(Title, [.. Sections]);
}

public static class PrototypeDemo
{
    public static void Run()
    {
        var original = new Document("Project Plan", ["Overview", "Timeline"]);
        var draft = original.Clone();
        draft.Title = "Project Plan - Draft";
        draft.Sections.Add("Risks");

        Console.WriteLine($"Original: {original.Title} ({string.Join(", ", original.Sections)})");
        Console.WriteLine($"Clone: {draft.Title} ({string.Join(", ", draft.Sections)})");
    }
}
