// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
int n = int.Parse(Console.ReadLine());
var stack = new Stack<long>();
var result = new StringBuilder();

var maxHistory = new Stack<long>();
maxHistory.Push(long.MinValue);

for (int i = 0; i < n; i++)
{
    int[] command = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

    switch (command[0])
    {

        case 1:
            if (command.Length > 1)
            {
                stack.Push(command[1]);

                if (command[1] >= maxHistory.Peek())
                {
                    maxHistory.Push(command[1]);
                }
            }

            break;
        case 2:
            if (stack.Count > 0)
            {
                var popped = stack.Pop();

                if (popped == maxHistory.Peek())
                {
                    maxHistory.Pop();
                }
            }

            break;
        case 3:
            result.Append($"{maxHistory.Peek()}{Environment.NewLine}");
            break;
        default:
            break;
    }
}


Console.WriteLine(result.ToString());
Console.WriteLine(result.ToString());
Console.WriteLine(stack);