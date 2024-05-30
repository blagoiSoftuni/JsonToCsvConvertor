// See https://aka.ms/new-console-template for more information

   string input = Console.ReadLine();
        string[] stringArray = input.Split(' ');
      int[] intArray = new int[stringArray.Length];
        for (int i = 0; i < stringArray.Length; i++)
        {
            intArray[i] = int.Parse(stringArray[i]);
        }

        double mean = CalculateMean(intArray);


       Console.WriteLine(mean);

       for (int i = 0; i < intArray.Length; i++)
        {
            if (intArray[i] > mean)
            {
                Console.Write(intArray[i]);

                
                if (i < intArray.Length - 1 && Array.Exists(intArray, element => element > mean))
                {
                    Console.Write(", ");
                }
            }
        }

        Console.ReadLine(); 
    

    static double CalculateMean(int[] array)
    {
        if (array.Length == 0)
        {
            return 0;
        }

        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }

        return (double)sum / array.Length;
    }


