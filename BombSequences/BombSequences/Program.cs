﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<int> sequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

List<int> specialNumAndPower = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

for (int i = 0; i < sequence.Count; i++)
{
    if (sequence[i] == specialNumAndPower[0])
    {
        int left = Math.Max(i - specialNumAndPower[1], 0);

        int right = Math.Min(i + specialNumAndPower[1], sequence.Count - 1);

        int lenght = right - left + 1;
        sequence.RemoveRange(left, lenght);
        i = 0;
    }
}

Console.WriteLine(sequence.Sum());
        
