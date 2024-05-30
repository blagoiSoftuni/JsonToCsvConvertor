// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
int transaction = int.Parse(Console.ReadLine());
int sum = input.Sum();
int workingHours = 0;

for (int i = 0; i < transaction; i++)
{
    transaction -= sum;

    if (workingHours % 4 == 0)
    {
        workingHours++;
    }
}

Console.WriteLine($"Time needed: {workingHours}h.");

       
