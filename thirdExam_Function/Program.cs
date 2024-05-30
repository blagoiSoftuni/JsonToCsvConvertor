// See https://aka.ms/new-console-template for more informatio
//int num = int.Parse(Console.ReadLine());

/*
string[] names = Console.ReadLine()
                .Split()
                .ToArray();
string returnednName = null;
 for (int i = 0; i <= names.Length - 1; i++)
            {
                Func<string, int> sumNames =a => a.Select(b => (int)b).Sum();
                int sum = sumNames(names[i]);
                if (num <= sum)
                {
                    returnednName = names[i];
                    break;
                }
            }
            Console.WriteLine(returnednName);
    */

int num = int.Parse(Console.ReadLine());

string[] names = Console.ReadLine()
                        .Split()
                        .ToArray();
string returnedName = null;

Func<string[], Func<string, int>, string> findName = (arr, func) =>
{
    string result = null;
    foreach (string name in arr)
    {
        int value = func(name);
        if (num <= value)
        {
            result = name;
            break;
        }
    }
    return result;
};

Func<string, int> calculateValue = (name) =>
{
    return name.Select(c => (int)c).Sum() * name.Select(c => (int)c).Aggregate((x, y) => x * y);
};

returnedName = findName(names, calculateValue);

Console.WriteLine(returnedName);
    }
}
