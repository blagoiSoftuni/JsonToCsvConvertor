// See https://aka.ms/new-console-template for more information

//List<String> list = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();



   
       
        List<string> inputGroups = Console.ReadLine().Split('|').ToList();

       
        List<int> examinedStudents = new List<int>();

      
        for (int i = inputGroups.Count - 1; i >= 0; i--)
        {
            
            List<int> numbers = new List<int>();
            string[] numberStrings = inputGroups[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string numberString in numberStrings)
            {
                if (int.TryParse(numberString, out int num))
                {
                    numbers.Add(num);
                }
            }

           
            examinedStudents.AddRange(numbers);
        }

       
        foreach (int studentNumber in examinedStudents)
        {
            Console.Write(studentNumber + " ");
        }
    



















