using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Thursday_Work_Object_Clases
{

    internal class Cars
    {
        public class Car
        {
            public string Name { get; set; }
            public string Model { get; set; }
            public string Engine { get; set; }

            public Car(string name, string model, string engine)
            {
                Name = name;
                Model = model;
                Engine = engine;
            }

            public override string ToString()
            {
                return $"Car - {Name} {Model} with engine {Engine}";
            }
        }

        public class Program
        {
            public static void Main()
            {
                List<Car> cars = new List<Car>();

                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "end")
                    {
                        break;
                    }

                    string[] parts = input.Split('/');
                    string name = parts[0];
                    string model = parts[1];
                    string engine = parts[2];

                    cars.Add(new Car(name, model, engine));
                }

                var sortedCars = cars.OrderBy(car => car.Name).ThenBy(car => car.Model).ToList();

                foreach (var car in sortedCars)
                {
                    Console.WriteLine(car);
                }
            }
        }
        }
}