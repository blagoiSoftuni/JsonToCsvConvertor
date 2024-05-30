// See https://aka.ms/new-console-template for more information
using System;


int n = int.Parse(Console.ReadLine());

SortedDictionary<string, int> mineralsCount = new SortedDictionary<string, int>();

for (int i = 0; i < n; i++)
{
    string [] line = Console.ReadLine().Split(" ");
    string typeOfelement = line[0];
    string nameOfElements = line[1];

    if (typeOfelement == "mineral")
    {
        if (!mineralsCount.ContainsKey(nameOfElements))
        {
            mineralsCount[nameOfElements] = 0;
        }
        mineralsCount[nameOfElements]++;
    }
}

foreach (var mineral in mineralsCount)
{
    Console.WriteLine($"{mineral.Key}: {mineral.Value} time/s");
}