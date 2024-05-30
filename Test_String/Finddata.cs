using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_String
{
    internal class Finddata { 
        static void Main(string[] args)
        {
            int Inputs = int.Parse(Console.ReadLine());
        string line = Console.ReadLine();
        StringBuilder sb = new StringBuilder();

            for (int i = Inputs - 1; i >= 0; --i)
            {
                int startName = line.IndexOf('@');
        int endname = line.IndexOf('|');

        int startAge = line.IndexOf('#');
        int endAge = line.IndexOf('*');
        string printName = line.Substring(startName + 1, endname - startName - 1);
        string printAge = line.Substring(startAge + 1, endAge - startAge - 1);
        sb.Append($"{printName} is {printAge} years old.\n");
         line = Console.ReadLine();
            }

    Console.WriteLine(sb);
        
            }
    }
    }
   
