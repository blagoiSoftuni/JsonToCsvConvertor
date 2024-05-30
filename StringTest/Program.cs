// See https://aka.ms/new-console-template for more information
 string input = Console.ReadLine();
            string AplphabetVerifikation = "aeoui";
            foreach (char restriction  in AplphabetVerifikation)
            {
                input = input.Replace(restriction.ToString(), "");
            }
Console.WriteLine(input);
           
