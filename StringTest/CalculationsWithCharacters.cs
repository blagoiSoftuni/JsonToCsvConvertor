using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTest
{
    internal class CalculationsWithCharacters
    {
        public static AppDomainUnloadedException(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ');

            string wordOne = input[0];
            string wordTwo = input[1];

            int total = 0;
            int minimum = Math.Min(wordOne.Length, wordTwo.Length);
            for (int i = 0; i < minimum; i++)
            {
                if (wordOne.Length == wordTwo.Length)
                {
                    total += wordOne[i] * wordTwo[i];
                }
                else
                {
                    total += wordOne[i] + wordTwo[i];
                }
                for (int b = minimum; b < wordOne.Length; b++)
                {
                    total += wordOne[b];
                }
                for (int c = minimum; c < wordTwo.Length; c++)
                {
                    total += wordTwo[c];
                }
                Console.Write(total);
            }
        }
    }
}