namespace Sets
{
    internal class Program
    {
        static void Main(string[] args)
        {
          HashSet<string> Specialguets = new HashSet<string>();
                HashSet<string> Regularguest = new HashSet<string>();

                bool Party = false;
                do
                {
                    string VurrentGuest = Console.ReadLine();

                    if (VurrentGuest == "END")
                    {
                        break;
                    }
                    if (VurrentGuest == "PARTY")
                    {
                        Party = true;
                        continue;
                    }
                    if (Party)
                    {
                        if (Specialguets.Contains(VurrentGuest))
                        {
                            Specialguets.Remove(VurrentGuest);
                        }
                        else if (Regularguest.Contains(VurrentGuest))
                        {
                            Regularguest.Remove(VurrentGuest);
                        }
                        continue;
                    }
                    if (Char.IsDigit(VurrentGuest[0]))
                    {
                        Specialguets.Add(VurrentGuest);
                    }
                    else
                    {
                        Regularguest.Add(VurrentGuest);
                    }
                }
                while (true);

                int numberOfComingGuests = Specialguets.Count + Regularguest.Count;
                Console.WriteLine(numberOfComingGuests);
                foreach (var guest in Specialguets)
            { 
                    Console.WriteLine(guest);
                }
                foreach (var guest in Regularguest)
                {
                    Console.WriteLine(guest);
                }
            }
        }

    }




       

        