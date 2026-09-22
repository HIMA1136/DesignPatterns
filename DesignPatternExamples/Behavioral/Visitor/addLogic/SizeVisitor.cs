namespace DesignPatternExamples.Visitor.addLogic;

public class SizeVisitor : IVisitor
{
    public int TotalSize { get; private set; } = 0;

    public void Visit(File file)
    {
        TotalSize += file.SizeInKb;
    }

    public void Visit(Folder folder)
    {
        // Folder doesn't add to size directly, only files do
    }
}