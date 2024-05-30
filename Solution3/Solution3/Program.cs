// See https://aka.ms/new-console-template for more information
using System.IO.IsolatedStorage;

int n = int.Parse(Console.ReadLine());
List<string> listMisiingstudents = new List<string>();
String name = Console.ReadLine();
String command = Console.ReadLine();
if(command == $"{name} is not here!") {
listMisiingstudents.Add(name);
    if (listMisiingstudents.Contains(name))
    {
        Console.WriteLine($"{name} is already in the list");
    } else if((command == $"{name} is here!"){
        if (listMisiingstudents.Contains(name))
        {
            listMisiingstudents.Remove(name);
        }
    }
}
for(int i = 0; i <= listMisiingstudents.Count; i++) { }
Console.WriteLine(listMisiingstudents.IndexOf(i);
