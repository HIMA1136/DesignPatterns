using DesignPatternExamples.Visitor.addLogic;

namespace DesignPatternExamples.Visitor;

public class File : IElement
{
    public string Name { get; set; }
    public int SizeInKb { get; set; }
    public Folder? Parent { get; set; }

    public File(string name, int sizeInKb)
    {
        Name = name;
        SizeInKb = sizeInKb;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }

    public string GetPath()
    {
        return Parent == null ? Name : $"{Parent.GetPath()}/{Name}";
    }
}

