public class Contest
{
    public string Name { get; }
    public string Password { get; }
    public Dictionary<string, int> Candidates { get; }

    public Contest(string name, string password)
    {
        Name = name;
        Password = password;
        Candidates = new Dictionary<string, int>();
    }
}

public class Candidate
{
    public string Name { get; }
    public Dictionary<string, int> ContestPoints { get; }

    public Candidate(string name)
    {
        Name = name;
        ContestPoints = new Dictionary<string, int>();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> contestPasswords = new Dictionary<string, string>();
        Dictionary<string, Contest> contests = new Dictionary<string, Contest>();
        List<Candidate> candidates = new List<Candidate>();

        string input;
        while ((input = Console.ReadLine()) != "the contests are ended")
        {
            string[] contestData = input.Split(':');
            string contestName = contestData[0];
            string password = contestData[1];

            contestPasswords[contestName] = password;
            contests[contestName] = new Contest(contestName, password);
        }

        while ((input = Console.ReadLine()) != "the submissions are ended")
        {
            string[] submissionData = input.Split("=>");
            string contestName = submissionData[0];
            string password = submissionData[1];
            string candidateName = submissionData[2];
            int points = int.Parse(submissionData[3]);

            if (contests.ContainsKey(contestName) && contestPasswords[contestName] == password)
            {
                Contest contest = contests[contestName];
                if (!contest.Candidates.ContainsKey(candidateName))
                {
                    Candidate candidate = new Candidate(candidateName);
                    candidates.Add(candidate);
                    contest.Candidates[candidateName] = points;
                    candidate.ContestPoints[contestName] = points;
                }
                else
                {
                    if (contest.Candidates[candidateName] < points)
                    {
                        contest.Candidates[candidateName] = points;
                        Candidate candidate = candidates.Find(c => c.Name == candidateName);
                        candidate.ContestPoints[contestName] = points;
                    }
                }
            }
        }

      
        Candidate bestCandidate = candidates.OrderByDescending(c => c.ContestPoints.Values.Sum()).First();
        int totalPoints = bestCandidate.ContestPoints.Values.Sum();
        Console.WriteLine($"Candidate number one is {bestCandidate.Name} with total {totalPoints} points.");

       
        foreach (var candidate in candidates.OrderBy(c => c.Name))
        {
            Console.WriteLine(candidate.Name);
            foreach (var contest in candidate.ContestPoints.OrderByDescending(cp => cp.Value))
            {
                Console.WriteLine($"# {contest.Key} -> {contest.Value}");

            }
        }
    }
}

       

        