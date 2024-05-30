// See https://aka.ms/new-console-template for more information

Dictionary<string, string> contests = new Dictionary<string, string>();
Dictionary<string, Dictionary<string, int>> candidates = new Dictionary<string, Dictionary<string, int>>();


while (true)
{
    string data = Console.ReadLine();
    if (data == "the contests are ended")
    {
        break;
    }
    string[] contestData = data.Split(':');
    contests.Add(contestData[0], contestData[1]);
}


while (true)
{
    string data = Console.ReadLine();
    if (data == "the submissions are ended")
    {
        break;
    }
    string[] submissionData = data.Split("=>");
    string contest = submissionData[0];
    string password = submissionData[1];
    string candidate = submissionData[2];
    int points = int.Parse(submissionData[3]);

    if (contests.ContainsKey(contest) && contests[contest] == password)
    {
        if (!candidates.ContainsKey(candidate))
        {
            candidates[candidate] = new Dictionary<string, int>();
        }
        if (!candidates[candidate].ContainsKey(contest) || points > candidates[candidate][contest])
        {
            candidates[candidate][contest] = points;
        }
    }
}

var bestCandidate = candidates.OrderByDescending(x => x.Value.Values.Sum()).First();


Console.WriteLine($"Candidate number one is {bestCandidate.Key} with total {bestCandidate.Value.Values.Sum()} points.");


foreach (var candidate in candidates.OrderBy(x => x.Key))
{
    Console.WriteLine(candidate.Key);
    foreach (var contest in candidate.Value.OrderByDescending(x => x.Value))
    {
        Console.WriteLine($"# {contest.Key} -> {contest.Value}");
    }
}
       
