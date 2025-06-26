using DesignPatternExamples.Memento.Entites;

namespace DesignPatternExamples.Memento.Entities;

public class HistoryManager
{
    private readonly Stack<Text> undoStack = new();
    private readonly Stack<Text> redoStack = new();

    public void Save(TextEditor editor)
    {
        undoStack.Push(editor.Save());
        redoStack.Clear();
    }

    public void Undo(TextEditor editor)
    {
        if (undoStack.Count > 1)
        {
            var current = undoStack.Pop();  

            redoStack.Push(current);      
            
            var previous = undoStack.Peek(); 

            editor.Restore(previous);              

        }
        else
        {
            Console.WriteLine("Nothing to undo.");
        }
    }

    public void Redo(TextEditor editor)
    {
        if (redoStack.Count > 0)
        {
            var memento = redoStack.Pop();

            undoStack.Push(editor.Save());      
            
            editor.Restore(memento);

        }
        else
        {
            Console.WriteLine("Nothing to redo.");
        }
    }

    private void PrintStack(string name, Stack<Text> stack)
    {
        Console.WriteLine($"--- {name} ---");

        if (stack.Count == 0)
        {
            Console.WriteLine("   [empty]");
            return;
        }

        foreach (var x in stack.Reverse())
        {
            Console.WriteLine("   " + x.Content);
        }
    }
}
