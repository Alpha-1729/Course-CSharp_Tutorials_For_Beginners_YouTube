// Delegates Usage 2

/*
>>>>
>>>>
>>>>
>>>>
>>>>
>>>>
*/

using System;
class Program
{
    static void Main()
    {
        List<Employee> employeeList = new List<Employee>();

        employeeList.Add(new Employee() { Id = 100, Name = "Mary", Salary = 1000, Experience = 5 });
        employeeList.Add(new Employee() { Id = 101, Name = "Sam", Salary = 10000, Experience = 6 });
        employeeList.Add(new Employee() { Id = 102, Name = "Peter", Salary = 5000, Experience = 7 });
        employeeList.Add(new Employee() { Id = 103, Name = "Rolex", Salary = 8000, Experience = 10 });
        employeeList.Add(new Employee() { Id = 104, Name = "Fita", Salary = 8900, Experience = 2 });

        IsPromotable isPromotable = new IsPromotable(Promote);

        Employee.PromoteEmployee(employeeList, isPromotable);

        // Or you can use lambda expression for the delegates.
        Employee.PromoteEmployee(employeeList, emp => emp.Experience > 5);

    }

    public static bool Promote(Employee emp)
    {
        if (emp.Experience > 5)
        {
            return true;
        }
        return false;
    }
}

public delegate bool IsPromotable(Employee employee);
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote)
    {
        foreach (Employee emp in employeeList)
        {
            if (IsEligibleToPromote(emp))
            {
                Console.WriteLine(emp.Name + " promoted");
            }
        }
    }
}