// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsTest
{
    internal class Calculations_with_Characters
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            string firstWord = input[0];
            string secondWord = input[1];

            int total = 0;
            int minimum = Math.Min(firstWord.Length, secondWord.Length);
            for (int i = 0; i < minimum; i++)
            {
                if (firstWord.Length == secondWord.Length)
                {
                    total += firstWord[i] * secondWord[i];
                }
                else
                {
                    total += firstWord[i] + secondWord[i];
                }
            }
            for (int i = minimum; i < firstWord.Length; i++)
            {
                total += firstWord[i];
            }
            for (int i = minimum; i < secondWord.Length; i++)
            {
                total += secondWord[i];
            }
            Console.WriteLine(total);
        }
    }
}