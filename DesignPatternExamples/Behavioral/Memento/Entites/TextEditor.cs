namespace DesignPatternExamples.Memento.Entites;

public class TextEditor
{
    public string Content { get; private set; } = "";

    public void Write(string text)
    {
        Content += text;
    }

    public Text Save()
    {
        return new Text(Content);
    }

    public void Restore(Text memento)
    {
        Content = memento.Content;
    }
}
