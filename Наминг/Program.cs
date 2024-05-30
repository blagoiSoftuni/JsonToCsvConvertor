// See https://aka.ms/new-console-template for more information



    string[] names = Console.ReadLine()
        .Split(" ").ToArray();
    Action<string> sir = names => Console.WriteLine($"Sir {names}");
    foreach (string name in names)
    {
        sir(name);
    }

    
