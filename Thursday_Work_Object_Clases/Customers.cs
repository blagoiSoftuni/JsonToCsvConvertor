using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thursday_Work_Object_Clases
{
    internal class Customers
    {
        class Customer
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Orders { get; set; }
            public string Status { get; set; }

            public Customer(string firstName, string lastName, int orders, string status)
            {
                FirstName = firstName;
                LastName = lastName;
                Orders = orders;
                Status = status;
            }

            public override string ToString()
            {
                return $"{FirstName} {LastName} has {Orders} orders.";
            }
        }

        class Program
        {
            static void Main()
            {
                List<Customer> customers = new List<Customer>();

                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "end")
                    {
                        break;
                    }

                    string[] parts = input.Split(' ');
                    string firstName = parts[0];
                    string lastName = parts[1];
                    int orders = int.Parse(parts[2]);
                    string status = parts[3];

                    customers.Add(new Customer(firstName, lastName, orders, status));
                }

                string targetStatus = Console.ReadLine();

                foreach (var customer in customers)
                {
                    if (customer.Status == targetStatus)
                    {
                        Console.WriteLine(customer);
                    }
                }
            }
        }

    }
}
