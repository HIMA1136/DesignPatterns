namespace DesignPatternExamples.Template.ConcreteImplementations;

public class PdfCVReportGenerator : CVReportGenerator
{
    protected override void ParseData()
    {
        Console.WriteLine("Parsing PDF data...");
        ParsedData = "Parsed PDF content";
    }

    protected override void GenerateSections()
    {
        Console.WriteLine("Generating CV sections from PDF...");
    }
}
