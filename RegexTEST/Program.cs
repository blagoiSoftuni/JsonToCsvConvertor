using System.Text.RegularExpressions;
using System.Text;

namespace RegexTEST
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = Console.ReadLine()
                   .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                   .ToList();
            Dictionary<string, int> Points = new Dictionary<string, int>();
            foreach (string line in list)
            {
                if (!Points.ContainsKey(line))
                {
                    Points.Add(line, 0);
                }
            }
            string input = Console.ReadLine();
            Regex nameHeroes = new Regex(@"[a-zA-Z]");
            Regex pointsForHeroes = new Regex(@"[\d]");

            while (input != "end")
            {
                MatchCollection Name = nameHeroes.Matches(input);
                MatchCollection pointsNum = pointsForHeroes.Matches(input);
                string hero = "";
                foreach (Match h in Name)
                {
                    hero += h.ToString();
                }
                int points = 0;
                foreach (Match point in pointsNum)
                {
                    points += int.Parse(point.ToString());
                }


                if (Points.ContainsKey(hero))
                {
                    Points[hero] += points;
                }
                input = Console.ReadLine();
            }
            int counter = 0;
            foreach (var item in Points.OrderBy(kvp => kvp.Value).Reverse())
            {

                if (counter == 3)
                {
                    break;
                }
                Console.WriteLine(item.Key);
                counter++;
            }




        }
    }
}

