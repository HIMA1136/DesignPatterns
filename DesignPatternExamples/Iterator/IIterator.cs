namespace DesignPatternExamples.Iterator;

public interface Iterator<T>
{
    public bool HasNext();
    public T Next();
}