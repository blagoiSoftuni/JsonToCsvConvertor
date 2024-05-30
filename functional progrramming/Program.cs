using System;
using System.Collections.Generic;
using System.Linq;

namespace functional_programming
{
    public class P4AppliedArithmetic
    {
        public static void Main(string[] args)
        {
            Func<List<int>, List<int>> add = list => list.Select(e => e + 1).ToList();
            Func<List<int>, List<int>> multiply = list => list.Select(e => e * 2).ToList();
            Func<List<int>, List<int>> subtract = list => list.Select(e => e - 1).ToList();
            Action<List<int>> print = list => list.ForEach(e => Console.Write(e + " "));

            List<int> input = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        input = add(input);
                        break;
                    case "multiply":
                        input = multiply(input);
                        break;
                    case "subtract":
                        input = subtract(input);
                        break;
                    case "print":
                        print(input);
                       
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
