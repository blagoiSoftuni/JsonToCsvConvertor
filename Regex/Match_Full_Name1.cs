using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex
{
    internal class Match_Full_Name1
    {
        static void Main(string[] args)
        {
            string pattern = @"\b([A-Z][a-z]{1,}) ([A-Z][a-z]{1,})\b";

            string input = Console.ReadLine();

            MatchCollection matches = (input, pattern);

            foreach (Match item in matches)
            {
                Console.Write((item.Value) + " ");
            }
            Console.WriteLine();
        }
    }
}
