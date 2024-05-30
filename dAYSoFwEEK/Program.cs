using System.Globalization;

namespace dAYSoFwEEK
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbersStr = input.Split(' ');
            int[] numbers = Array.ConvertAll(numbersStr, int.Parse);

            // Shuffle the array
            Random rnd = new Random();
            for (int i = numbers.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(0, i + 1);
                // Swap numbers[i] and numbers[j]
                int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }

            // Print each number in the shuffled array on a new line
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}

