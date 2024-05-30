// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System;
using System.Collections.Generic;


    
        List<int> numbers = Console.ReadLine()
              .Split(" ")
              .Select(int.Parse)
              .ToList();

        int sum = SumNumbersInOrder(numbers);

Console.WriteLine(sum);


static int SumNumbersInOrder(List<int> numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Count / 2; i++)
        {
          
            sum += numbers[i] + numbers[numbers.Count - 1 - i];
        }

      
        if (numbers.Count % 2 != 0)
        {
            sum += numbers[numbers.Count / 2];

        }

        return sum;
    }

