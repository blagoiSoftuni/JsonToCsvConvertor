// See https://aka.ms/new-console-template for more information
List<int>numbersOne = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> numbersTwo = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();
List<int> result = new List<int>();

for (int i = 0; i < Math.Max(numbersOne.Count, numbersTwo.Count); i++)
{
    if (i < numbersOne.Count)
    {
        result.Add(numbersOne[i]);
    }

    if (i < numbersTwo.Count)
    {
        result.Add(numbersTwo[i]);
    }
}

Console.WriteLine(string.Join(" ", result));                   
      