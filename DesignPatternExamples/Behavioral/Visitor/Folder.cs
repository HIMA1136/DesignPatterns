using DesignPatternExamples.Visitor.addLogic;

namespace DesignPatternExamples.Visitor;

public class Folder : IElement
{
    public string Name { get; set; }
    public Folder? Parent { get; set; }

    public List<IElement> Children { get; } = new();

    public Folder(string name)
    {
        Name = name;
    }

    public void Add(IElement item)
    {
        item.Parent = this;
        Children.Add(item);
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
        foreach (var child in Children)
        {
            child.Accept(visitor);
        }
    }

    public string GetPath()
    {
        return Parent == null ? Name : $"{Parent.GetPath()}/{Name}";
    }
}
