class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Employee> employees = new List<Employee>();

        for (int i = 0; i < n; i++)
        {
            string[] employeeProfile = Console.ReadLine().Split();
            string name = employeeProfile[0];
            double salary = double.Parse(employeeProfile[1]);
            string department = employeeProfile[2];

            employees.Add(new Employee(name, salary, department));
        }

        // Намиране на всички уникални отдели
        var departments = employees.Select(e => e.Department).Distinct();

        string highestAvgSalaryDept = null;
        double highestAvgSalary = double.MinValue;

        // Проход през всеки отдел и намиране на средната заплата
        foreach (var department in departments)
        {
            // Филтриране на служителите спрямо текущия отдел
            var departmentEmployees = employees.Where(e => e.Department == department);

            // Изчисляване на средната заплата за текущия отдел
            double avgSalary = departmentEmployees.Any() ? departmentEmployees.Average(e => e.Salary) : 0;

            // Проверка дали средната заплата за текущия отдел е най-голямата досега
            if (avgSalary > highestAvgSalary)
            {
                highestAvgSalary = avgSalary;
                highestAvgSalaryDept = department;
            }
        }

        // Извеждане на отдела с най-голяма средна заплата и на служителите в него
        Console.WriteLine($"Highest Average Salary: {highestAvgSalaryDept}");
        foreach (var employee in employees.Where(e => e.Department == highestAvgSalaryDept).OrderByDescending(e => e.Salary))
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