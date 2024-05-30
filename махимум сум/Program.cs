// See https://aka.ms/new-console-template for more information

    Func<string, int, bool> SelectingNames = (a, b) => a.Length <= b;
    int Countofnames = int.Parse(Console.ReadLine());
    string[] names = Console.ReadLine().Split().Where(c => SelectingNames(c, Countofnames)) .ToArray();

    Action<string> printingnames = d => Console.WriteLine(d);
foreach (string name in names)
{
    printingnames(name);
}
    


