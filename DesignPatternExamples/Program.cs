using DesignPatternExamples.Observer;
using DesignPatternExamples.Strategy;
using DesignPatternExamples.Template;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Choose a design pattern to run:");
Console.WriteLine("1 - Observer Pattern");
Console.WriteLine("2 - Strategy Pattern");
Console.WriteLine("3 - Template Pattern");
Console.WriteLine("Enter 'exit' to quit.");
Console.ResetColor();

string? input;
do
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("\nEnter your choice: ");
    Console.ResetColor();
    input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nRunning Observer Pattern Example:\n");
            Console.ResetColor();
            ObserverDemo.Run();
            break;
        case "2":
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nRunning Strategy Pattern Example:\n");
            Console.ResetColor();
            StrategyDemo.Run();
            break;
        case "3":
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nRunning Template Pattern Example:\n");
            Console.ResetColor();
            TemplateDemo.Run();
            break;
        case "exit":
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid choice. Please enter 1, 2, 3 or 'exit'.");
            Console.ResetColor();
            break;
    }
} while (input?.ToLower() != "exit");
