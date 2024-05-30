using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex
{
    internal class MatchPhoneNumber1
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";

                string input = Console.ReadLine();

                string[] matches = Regex
                    .Matches(input, pattern)
                    .Select(x => x.Value)
                    .ToArray();

                Console.WriteLine(string.Join(", ", matches));
            }
        }

    }
}
