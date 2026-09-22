namespace DesignPatternExamples.Template;

public abstract class CVReportGenerator
{
    public void GenerateReport(string filePath)
    {
        Console.WriteLine("Starting CV report generation...");

        LoadFile(filePath);
        ParseData();
        GenerateSections();
        ExportReport();

        Console.WriteLine("CV report generation completed.\n");
    }

    protected string? FilePath;
    protected object? ParsedData;

    protected virtual void LoadFile(string filePath)
    {
        FilePath = filePath;
        Console.WriteLine($"Loading file: {filePath}");
    }

    protected abstract void ParseData();
    protected abstract void GenerateSections();

    protected virtual void ExportReport()
    {
        Console.WriteLine("Exporting report to PDF...");
    }
}
