using DesignPatternExamples.Template.ConcreteImplementations;

namespace DesignPatternExamples.Template;

public static class TemplateDemo
{
    public static void Run()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n--- Template Method Pattern Example ---");
        Console.ResetColor();

        string excelPath = @"C:\\CVs\\cv_excel.xlsx";
        string pdfPath = @"C:\\CVs\\cv_pdf.pdf";
        string imagePath = @"C:\\CVs\\cv_photo.png";

        CVReportGenerator excelGenerator = new ExcelCVReportGenerator();
        CVReportGenerator pdfGenerator = new PdfCVReportGenerator();
        CVReportGenerator photoGenerator = new PhotoCVReportGenerator();

        excelGenerator.GenerateReport(excelPath);
        pdfGenerator.GenerateReport(pdfPath);
        photoGenerator.GenerateReport(imagePath);

        Console.WriteLine("All CV reports processed.");

    }
}
