// See https://aka.ms/new-console-template for more information
int[] NSX = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToArray();

int N = NSX[0];
int S = NSX[1];
int X = NSX[2];

int[] arrayOfNums = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Stack<int> queue = new Stack<int>();

for (int i = 0; i < N; i++)
{
    queue.Push(arrayOfNums[i]);
}

for (int i = 0; i < S; i++)
{
    queue.Pop();
}

if (queue.Contains(X))
{
    Console.WriteLine("found");
}

else if (queue.Count == 0)
{
    Console.WriteLine("nothing found");
}

else
{
    Console.WriteLine(queue.Min());
}
        