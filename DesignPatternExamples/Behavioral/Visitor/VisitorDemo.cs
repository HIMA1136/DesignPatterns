using DesignPatternExamples.Template.ConcreteImplementations;
using DesignPatternExamples.Template;
using DesignPatternExamples.Visitor.addLogic;

namespace DesignPatternExamples.Visitor;

public static class VisitorDemo
{
    public static void Run()
    {
        // Build file system
        var root = new Folder("Root");
        var docs = new Folder("Documents");
        var images = new Folder("Images");

        docs.Add(new File("Resume.docx", 120));
        docs.Add(new File("Project.pdf", 230));

        images.Add(new File("photo1.jpg", 1024));
        images.Add(new File("photo2.png", 2048));

        root.Add(docs);
        root.Add(images);

        // Size Visitor
        var sizeVisitor = new SizeVisitor();
        root.Accept(sizeVisitor);
        Console.WriteLine($"\nTotal Size: {sizeVisitor.TotalSize} KB");

        // Report Visitor
        Console.WriteLine("\n--- File System Report ---");
        var reportVisitor = new ReportVisitor();
        root.Accept(reportVisitor);

    }
}
