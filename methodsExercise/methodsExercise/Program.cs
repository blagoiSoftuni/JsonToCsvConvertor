// See https://aka.ms/new-console-template for more information

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
Console.WriteLine(printtheSmallestNumber);
static void printtheSmallestNumber(int a, int b, int c) => Console.WriteLine(Math.Min(a, Math.Min(b, c)));
{ }
