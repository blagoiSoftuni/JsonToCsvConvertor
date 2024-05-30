using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsTest
{
    internal class Find_Data
    {
          static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string AplphabetVerifikation = "aeouiAEOUI";
            foreach (char restriction  in AplphabetVerifikation)
            {
                input = input.Replace(restriction.ToString(), "");
            }
            Console.WriteLine(input);
    }
}
