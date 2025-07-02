using DesignPatternExamples.Visitor.addLogic;

namespace DesignPatternExamples.Visitor;

public interface IElement
{

        public string Name { get; }
        public Folder? Parent { get; set; } // link to parent for path logic
        public string GetPath();
        public void Accept(IVisitor visitor);
    

}
