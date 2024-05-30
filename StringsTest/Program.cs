// See https://aka.ms/new-console-template for more information
using System.Text;
using System.Text.RegularExpressions;

string input = Console.ReadLine();
string regex = @"\@(?<metal>\w+)\|.*?#(?<gem>\w+)\*";
Regex pattern = new Regex(regex);
StringBuilder output = new StringBuilder();
if (pattern.IsMatch(input))
{
    Match matched = pattern.Match(input);
    output.Append($"Found hidden {matched.Groups["metal"].Value} and {matched.Groups["gem"].Value} in the cave.");
}
string finalOutput = output.ToString();
Console.WriteLine(finalOutput);
        }
    }


