// See https://aka.ms/new-console-template for more information
static char? CheckCollision(List<string> cars, int window)
{
    foreach (var car in cars)
    {
        if (car.Length >= window)
        {
            return car[window - 1];
        }
    }
    return null;
}


    int greenLightDuration = int.Parse(Console.ReadLine());
    int freeWindow = int.Parse(Console.ReadLine());

    List<string> cars = new List<string>();
    int totalCarsPassed = 0;

    while (true)
    {
        string command = Console.ReadLine();

        if (command == "STOP")
        {
            Console.WriteLine("Success!");
            Console.WriteLine($"{totalCarsPassed} total cars are gone.");
            break;
        }

        if (command == "light")
        {
            char? characterHit = CheckCollision(cars, freeWindow);
            if (characterHit != null)
            {
                Console.WriteLine("Accident!");
                Console.WriteLine($"{characterHit} was crushed at {freeWindow}.");
                break;
            }
            else
            {
                if (cars.Count > 0)
                {
                    totalCarsPassed++;
                }
                cars.Clear();
            }
        }
        else
        {
            cars.Add(command);
        }
    }
