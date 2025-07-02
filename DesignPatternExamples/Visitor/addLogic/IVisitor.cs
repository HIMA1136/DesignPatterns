namespace DesignPatternExamples.Visitor.addLogic;

public interface IVisitor
{
    void Visit(File file);
    void Visit(Folder folder);
}
