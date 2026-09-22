namespace DesignPatternExamples.Template.ConcreteImplementations;

public class PhotoCVReportGenerator : CVReportGenerator
{
    protected override void ParseData()
    {
        Console.WriteLine("Analyzing photo using OCR...");
        ParsedData = "Text extracted from image";
    }

    protected override void GenerateSections()
    {
        Console.WriteLine("Generating CV sections from photo OCR...");
    }
}
