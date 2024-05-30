// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Linq;

string input = Console.ReadLine();
        string[] stringArray = input.Split(' ');
        int[] Array = new int[stringArray.Length];
        for (int i = 0; i < stringArray.Length; i++)
        {
            Array[i] = int.Parse(stringArray[i]);
        }
        int max = FindLargeValue(Array);
        Console.WriteLine(max);


        for (int i = 0; i < Array.Length; i++)
        {
            Console.Write(Array[i]);


            if (i < Array.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.ReadLine();

        static int FindLargeValue(int[] array)
        {
            int max = int.MinValue;
            foreach (int num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
    












