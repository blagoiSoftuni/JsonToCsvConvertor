﻿namespace Destroyer
{
    internal class Program
    {
      static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            var elements = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in input)
                {
                    if (!elements.Contains(item))
                    {
                        elements.Add(item);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", elements.OrderBy(x => x)));
        }
    }
} 
           



   