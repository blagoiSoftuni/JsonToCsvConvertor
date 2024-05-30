// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using System.Text;

/*
List<string> list = Console.ReadLine()
             .Split(", ", StringSplitOptions.RemoveEmptyEntries)
             .ToList();
Dictionary<string, int> HeroPoints = new Dictionary<string, int>();
foreach (string line in list)
{
    if (!HeroPoints.ContainsKey(line))
    {
        HeroPoints.Add(line, 0);
    }
}
string input = Console.ReadLine();
Regex HeroNameRegex = new Regex(@"[a-zA-Z]");
Regex PointsNumregex = new Regex(@"[\d]");

while (input != "end")
{
    MatchCollection heroName = HeroNameRegex.Matches(input);
    MatchCollection pointsNum = PointsNumregex.Matches(input);
    string hero = "";
    foreach (Match h in heroName)
    {
        hero += h.ToString();
    }
    int points = 0;
    foreach (Match point in pointsNum)
    {
        points += int.Parse(point.ToString());
    }


    if (HeroPoints.ContainsKey(hero))
    {
        HeroPoints[hero] += points;
    }
    input = Console.ReadLine();
}
int counter = 0;
foreach (var item in HeroPoints.OrderBy(kvp => kvp.Value).Reverse())
{

    if (counter == 3)
    {
        break;
    }
    Console.WriteLine(item.Key);
    counter++;
}
            
        }
 */
string input = "";
input = Console.ReadLine();
string regex = @"<>(?<name>\w+)<>(?<quantity>\d+)--(?<price>\d+.?(\d+)?)";
Regex patter = new Regex(regex);
List<string> names = new List<string>();
List<int> quantitys = new List<int>();
List<double> prices = new List<double>();
double totalCost = 0;
while (input != "Run!")
{
    if (!patter.IsMatch(input))
    {
        Match matched = patter.Match(input);
        string name = matched.Groups["name"].Value;
        names.Add(matched.Groups["name"].Value);
        quantitys.Add(int.Parse(matched.Groups["quantity"].Value));
        prices.Add(double.Parse(matched.Groups["price"].Value));
    }
    input = Console.ReadLine();
}
Console.WriteLine("Gear bought:");
for (int i = 0; i <= names.Count; i++)
{
    Console.WriteLine(names[i]);
    totalCost += prices[i] * quantitys[i];
}
Console.WriteLine($"Total cost: {totalCost:f2}");
*\ 
    string input = "";
input = Console.ReadLine();
string regex = @"<>(?<name>\w+)<>(?<quantity>\d+)--(?<price>\d+.?(\d+)?)";
Regex patter = new Regex(regex);
List<string> names = new List<string>();
List<int> quantitys = new List<int>();
List<double> prices = new List<double>();
double totalCost = 0;
while (input != "Run!")
{
    if (!patter.IsMatch(input))
    {
        Match matched = patter.Match(input);
        string name = matched.Groups["name"].Value;
        names.Add(matched.Groups["name"].Value);
        quantitys.Add(int.Parse(matched.Groups["quantity"].Value));
        prices.Add(double.Parse(matched.Groups["price"].Value));
    }
    input = Console.ReadLine();
}
Console.WriteLine("Gear bought:");
for (int i = 0; i <= names.Count; i++)
{
    Console.WriteLine(names[i]);
    totalCost += prices[i] * quantitys[i];
}
Console.WriteLine($"Total cost: {totalCost:f2}");