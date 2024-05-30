// See https://aka.ms/new-console-template for more information

       
        int classroomSize = int.Parse(Console.ReadLine());

        
        List<string> presentStudents = new List<string>();
        List<string> missingStudents = new List<string>();

        for (int i = 0; i < classroomSize; i++)
        {
            string message = Console.ReadLine();

          
            if (message.EndsWith(" is not here!"))
            {
                string name = message.Replace(" is not here!", "");

                if (!missingStudents.Contains(name))
                {
                    missingStudents.Add(name);
                   
                }
                else
                {
                    Console.WriteLine($"{name} is already in the list!");
                }
            }

            else if (message.EndsWith(" is here!"))
            {
                string name = message.Replace(" is here!", "");

                if (missingStudents.Contains(name))
                {
                    missingStudents.Remove(name);
                    presentStudents.Add(name);
                    Console.WriteLine($"{name} is in class!");
                }
                else
                {
                    Console.WriteLine($"{name} is already in class!");
                }
            }
        }

        
       

        foreach (string student in missingStudents)
        {
            Console.WriteLine(student);
        }
    
   

