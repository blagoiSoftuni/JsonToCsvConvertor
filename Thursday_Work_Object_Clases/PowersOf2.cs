using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Thursday_Work_Object_Clases
{
    internal class PowersOf2
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());


            BigInteger result = new BigInteger(1);


            for (int i = 0; i < N; i++)
            {
                result *= 2;
            }

            Console.WriteLine(result);
        }
    }
}

