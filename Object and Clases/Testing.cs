using System;
using System.Collections.Generic;
using System.Linq;

class Testing
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Employee> employees = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            string[] employeeInfo = Console.ReadLine().Split();
            string name = employeeInfo[0];
            double salary = double.Parse(employeeInfo[1]);
            string department = employeeInfo[2];

            employees.Add(new Employee(name, salary, department));
        }

        var highestAvgSalaryDept = employees
            .GroupBy(e => e.Department)
            .OrderByDescending(g => g.Average(e => e.Salary))
            .First();

        Console.WriteLine($"Highest Average Salary: {highestAvgSalaryDept.Key}");
        foreach (var employee in highestAvgSalaryDept.OrderByDescending(e => e.Salary))
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
        }
    }
}

class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }

    public Employee(string name, double salary, string department)
    {
        Name = name;
        Salary = salary;
        Department = department;
    }
}



