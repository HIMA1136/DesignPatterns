namespace DesignPatternExamples.Iterator;

public class EmployeeIterator : Iterator<Employee>
{
    private readonly List<Employee> _employees;
    private int _index = 0;

    public EmployeeIterator(List<Employee> employees)
    {
        _employees = employees;
    }

    public bool HasNext()
    {
        return _index < _employees.Count;
    }

    public Employee Next()
    {
        return _employees[_index++];
    }
}
