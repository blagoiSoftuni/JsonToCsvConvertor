//




//namespace employees;
    class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Employees> employees = new List<Employees>();


        for (int i = 0; i < n; i++)
        {
            string[] studentInfo = Console.ReadLine().Split();
            string firstName = studentInfo[0];
            string lastName = studentInfo[1];
            double grade = double.Parse(studentInfo[2]);

            Employees employee = new Employees(firstName, lastName, grade);
            employees.Add(employee);
        }

        employees.Sort((x, y) => y.Salary.CompareTo(x.Salary));
        foreach (var employed in employees)
        {
            Console.WriteLine(employed);
        }




    }
}

class Employees
{
    public string FirstName
    { get; set;}
         
   
  public string LastName { get; set; }
    public double Salary { get; set; }
    public Employees(string firstName, string lastName, double salary) {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }
public override string ToString ()
    {
            return $"{FirstName} {LastName}: {Salary:F2}";
        }
    }
}
