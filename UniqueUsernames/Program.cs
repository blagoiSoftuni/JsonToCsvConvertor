// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());
var Names = new List<string>();

for (int i = 0; i < n; i++)
{
    String name = Console.ReadLine();
    if (!Names.Contains(name))
    {
        Names.Add(name);
    }
}

foreach (var name in Names)
{
    Console.WriteLine(name);
}
       