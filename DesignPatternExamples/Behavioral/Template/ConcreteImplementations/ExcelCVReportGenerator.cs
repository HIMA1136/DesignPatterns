namespace DesignPatternExamples.Template.ConcreteImplementations;

public class ExcelCVReportGenerator : CVReportGenerator
{
    protected override void ParseData()
    {
        Console.WriteLine("Parsing Excel data...");
        ParsedData = "Parsed Excel content";
    }

    protected override void GenerateSections()
    {
        Console.WriteLine("Generating CV sections from Excel...");
    }
}
