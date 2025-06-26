using DesignPatternExamples.Observer.Entittes;
using DesignPatternExamples.Observer;
using DesignPatternExamples.Memento.Entites;
using DesignPatternExamples.Memento.Entities;

namespace DesignPatternExamples.Memento;

public static class MementoDemo
{
    public static void Run()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n--- Memento Pattern Example ---");
        Console.ResetColor();

        var editor = new TextEditor();
        var history = new HistoryManager();

        editor.Write("Hello");
        history.Save(editor);  

        editor.Write(" World");
        history.Save(editor);  

        editor.Write(" New");
        history.Save(editor);  

        editor.Write(" Student");
        history.Save(editor);  

        Console.WriteLine("Current: " + editor.Content); 

        history.Undo(editor);
        Console.WriteLine("After Undo: " + editor.Content); 

        history.Undo(editor);
        Console.WriteLine("After Undo: " + editor.Content); 

        history.Undo(editor);
        Console.WriteLine("After Undo: " + editor.Content); 

        history.Redo(editor);
        Console.WriteLine("After Redo: " + editor.Content); 

        history.Redo(editor);
        Console.WriteLine("After Redo: " + editor.Content); 

        history.Redo(editor);
        Console.WriteLine("After Redo: " + editor.Content); 


    }
}
