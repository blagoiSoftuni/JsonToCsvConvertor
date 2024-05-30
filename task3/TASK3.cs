// See https://aka.ms/new-console-template for more information

int greenLightDuration = int.Parse(Console.ReadLine());
int freeWindow = int.Parse(Console.ReadLine());

var carsToPass = new Queue<string>();

var passedCars = new Stack<string>();

string command = string.Empty;

while ((command = Console.ReadLine()) != "END")
{
    if (command != "green")
    {
        carsToPass.Enqueue(command);
    }
    else
    {
        int greenLight = greenLightDuration;
        int freePass = freeWindow;

        int counter = carsToPass.Count;

        for (int i = 0; i < counter; i++)
        {
            if (greenLight >= carsToPass.Peek().Length && carsToPass.Any())
            {
                greenLight -= carsToPass.Peek().Length;
                passedCars.Push(carsToPass.Dequeue());
            }

            else if (greenLight < carsToPass.Peek().Length && carsToPass.Any())
            {
                int timeLeft = greenLight + freePass;

                if (greenLight <= 0)
                {
                    continue;
                }

                else if (timeLeft > 0 && timeLeft >= carsToPass.Peek().Length)
                {
                    string car = carsToPass.Peek();
                    timeLeft -= car.Length;
                    passedCars.Push(carsToPass.Dequeue());
                    greenLight = 0;
                    freePass = 0;
                }

                else if (timeLeft > 0 && timeLeft < carsToPass.Peek().Length)
                {
                    string car = carsToPass.Peek();

                    Console.WriteLine("Crash on the crosshand!");
                    int hit = timeLeft;
                    Console.WriteLine($"{car} was hit at {car[hit]}.");
                    return;
                }
            }
        }
    }
}

Console.WriteLine("No crash happened");
Console.WriteLine($"{passedCars.Count} total cars passed the crossroads.");
        