namespace DesignPatternExamples.Iterator;

public static class IteratorDemo
{
    public static void Run()
    {
        HRDepartment hr = new HRDepartment();

        hr.AddEmployee(new Employee("Alice", "Recruiter"));
        hr.AddEmployee(new Employee("Bob", "HR Manager"));
        hr.AddEmployee(new Employee("Carol", "Trainer"));

        Iterator<Employee> iterator = hr.CreateIterator();

        while (iterator.HasNext())
        {
            Employee emp = iterator.Next();
            Console.WriteLine($"{emp.Name} - {emp.Position}");

        }

    }
}
