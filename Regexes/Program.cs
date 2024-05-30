// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using System.Text;

/*string input = Console.ReadLine();
string regex = @"\@(?<metal>\w+)\|.*?#(?<gem>\w+)";
Regex pattern = new Regex(regex);
StringBuilder output = new StringBuilder();
if (pattern.IsMatch(input))
{
    Match matched = pattern.Match(input);
    output.Append($"Found hidden {matched.Groups["metal"].Value} and {matched.Groups["gem"].Value} in the cave.");
}
string finalOutput = output.ToString();
Console.WriteLine(finalOutput);
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
