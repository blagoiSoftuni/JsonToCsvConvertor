// See https://aka.ms/new-console-template for more information
// A class to store the spray amount and the day of death for a plant
class Plant
{
    public int spray;
    public int deathDay;

    public Plant(int spray, int deathDay)
    {
        this.spray = spray;
        this.deathDay = deathDay;
    }


    // A function to return the number of days after which no plant dies
    static int poisonousPlants(int[] p)
    {
        // Initialize a stack to store the plants
        Stack<Plant> stack = new Stack<Plant>();

        // Initialize the maximum day of death
        int maxDeathDay = 0;

        // Iterate over the input array
        for (int i = 0; i < p.Length; i++)
        {
            // Initialize the current day of death as zero
            int deathDay = 0;

            // While the stack is not empty and the top plant has more or equal spray than the current plant
            while (stack.Count > 0 && stack.Peek().spray >= p[i])
            {
                // Update the current day of death as the maximum of the previous day of death and the current day
                deathDay = Math.Max(deathDay, stack.Pop().deathDay);
            }

            // If the stack is not empty, then the current plant will die eventually
            if (stack.Count > 0)
            {
                // Increment the current day of death by one
                deathDay++;
            }

            // Update the maximum day of death
            maxDeathDay = Math.Max(maxDeathDay, deathDay);

            // Push the current plant with its spray amount and day of death to the stack
            stack.Push(new Plant(p[i], deathDay));
        }

        // Return the maximum day of death
        return maxDeathDay;
    }

    static void Main(string[] args)
    {
        // Read the number of plants from the standard input
        int n = Convert.ToInt32(Console.ReadLine());

        // Read the spray amounts for each plant from the standard input
        int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp));

        // Call the function to get the number of days after which no plant dies
        int result = poisonousPlants(p);

        // Print the result to the standard output
        Console.WriteLine(result);
    }
}
