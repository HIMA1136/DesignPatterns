namespace DesignPatternExamples.Visitor.addLogic;

public class ReportVisitor : IVisitor
{
    private int depth = 0;

    public void Visit(File file)
    {
        Console.WriteLine(new string(' ', depth * 2) + "- File: " + file.Name + $" ({file.SizeInKb} KB)");
    }

    public void Visit(Folder folder)
    {
        Console.WriteLine(new string(' ', depth * 2) + "+ Folder: " + folder.Name);
        depth++;
    }
}