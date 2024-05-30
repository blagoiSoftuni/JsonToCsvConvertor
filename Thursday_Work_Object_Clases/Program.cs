namespace Thursday_Work_Object_Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
          string[] inputStrings = input.Split(' ');

           
            int[] numbers = Array.ConvertAll(inputStrings, int.Parse);

               Random rnd = new Random();

            for (int i = numbers.Length - 3; i > 0; i--)
            {
               
                int j = rnd.Next(0, i + 1);

                 int temp = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = temp;
            }

            
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
    }
