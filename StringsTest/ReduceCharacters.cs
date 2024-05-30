using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using.System.StringBuilder;

namespace StringsTest
{
    internal class ReduceCharacters
    {
        static void Main(string[] args)
        {
            int numOfInputs = int.Parse(Console.ReadLine());
        string line = Console.ReadLine();
        StringBuilder sb = new StringBuilder();

            for (int i = numOfInputs - 1; i >= 0; --i)
            {
                int locationOfNameStart = line.IndexOf('@');
        int locationOfNameEnd = line.IndexOf('|');

        int locationOfAgeStart = line.IndexOf('#');
        int locationOfAgeEnd = line.IndexOf('*');

        string name = line.Substring(locationOfNameStart + 1, locationOfNameEnd - locationOfNameStart - 1);
        string age = line.Substring(locationOfAgeStart + 1, locationOfAgeEnd - locationOfAgeStart - 1);
        sb.Append($"{name} is {age} years old.\n");
               
                line = Console.ReadLine();
            }
    Console.WriteLine(sb);
        }
    }
    }
}
