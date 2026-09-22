using DesignPatternExamples.Iterator;
using DesignPatternExamples.Mediator;
using DesignPatternExamples.Memento;
using DesignPatternExamples.Observer;
using DesignPatternExamples.State;
using DesignPatternExamples.Strategy;
using DesignPatternExamples.Template;
using DesignPatternExamples.Visitor;
using DesignPatternExamples.Structural.Adapter;
using DesignPatternExamples.Structural.Bridge;
using DesignPatternExamples.Structural.Composite;
using DesignPatternExamples.Structural.Decorator;
using DesignPatternExamples.Structural.Facade;
using DesignPatternExamples.Structural.Flyweight;
using DesignPatternExamples.Structural.Proxy;
using DesignPatternExamples.Creational.Builder;
using DesignPatternExamples.Creational.Singleton;
using DesignPatternExamples.Creational.Prototype;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Choose a design pattern to run:");
Console.WriteLine("1 - Observer Pattern");
Console.WriteLine("2 - Strategy Pattern");
Console.WriteLine("3 - Template Pattern");
Console.WriteLine("4 - Memento Pattern");
Console.WriteLine("5 - Visitor Pattern");
Console.WriteLine("6 - Iterator Pattern");
Console.WriteLine("7 - State Pattern");
Console.WriteLine("8 - Mediator Pattern");
Console.WriteLine("9 - Adapter Pattern");
Console.WriteLine("10 - Bridge Pattern");
Console.WriteLine("11 - Composite Pattern");
Console.WriteLine("12 - Decorator Pattern");
Console.WriteLine("13 - Facade Pattern");
Console.WriteLine("14 - Proxy Pattern");
Console.WriteLine("15 - Flyweight Pattern");
Console.WriteLine("16 - Builder Pattern");
Console.WriteLine("17 - Singleton Pattern");
Console.WriteLine("18 - Prototype Pattern");

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
        case "4":
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nRunning Memento Pattern Example:\n");
            Console.ResetColor();
            MementoDemo.Run();
            break;
        case "5":
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nRunning Visitor Pattern Example:\n");
            Console.ResetColor();
            VisitorDemo.Run();
            break;
        case "6":
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nRunning Iterator Pattern Example:\n");
            Console.ResetColor();
            IteratorDemo.Run();
            break;
        case "7":
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nRunning State Pattern Example:\n");
            Console.ResetColor();
            StateDemo.Run();
            break;
        case "8":
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nRunning Mediator Pattern Example:\n");
            Console.ResetColor();
            MediatorDemo.Run();
            break;
        case "9": AdapterDemo.Run(); break;
        case "10": BridgeDemo.Run(); break;
        case "11": CompositeDemo.Run(); break;
        case "12": DecoratorDemo.Run(); break;
        case "13": FacadeDemo.Run(); break;
        case "14": ProxyDemo.Run(); break;
        case "15": FlyweightDemo.Run(); break;
        case "16": BuilderDemo.Run(); break;
        case "17": SingletonDemo.Run(); break;
        case "18": PrototypeDemo.Run(); break;
        case "exit":
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid choice. Please enter a number from 1 to 18 or 'exit'.");
            Console.ResetColor();
            break;
    }
} while (input?.ToLower() != "exit");
