// See https://aka.ms/new-console-template for more information
using System.Numerics;

List<string> names = new List<string>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    names.Add(name);
}
names.Sort();



foreach (string name in names)
{
    Console.WriteLine(name);
}
   
