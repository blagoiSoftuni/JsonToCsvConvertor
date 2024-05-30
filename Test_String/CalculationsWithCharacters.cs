using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_String
{
    internal class CalculationsWithCharacters
    {

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
                }
                for (int i = minimum; i < wordOne.Length; i++)
                {
                    total += wordOne[i];
                }
                for (int i = minimum; i < wordTwo.Length; i++)
                {
                    total += wordTwo[i];
                }
                Console.WriteLine(total);
            }
        }
    }
}
}
