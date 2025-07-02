namespace DesignPatternExamples.Iterator;

public class HRDepartment : IEmployeeCollection
{
    private readonly List<Employee> _employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }

    public Iterator<Employee> CreateIterator()
    {
        return new EmployeeIterator(_employees);
    }
}

