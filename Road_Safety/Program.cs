namespace Road_Safety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int totalCars = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "STOP")
                {
                    Console.WriteLine("Success!");
                    Console.WriteLine($"{totalCars} total cars are gone.");
                    break;
                }

                if (command == "light")
                {
                    int Left_time = greenLight;
                    while (cars.Count > 0)
                    {
                        string car = cars.Dequeue();
                        if (car.Length < Left_time)
                        {
                            Left_time -= car.Length;
                            totalCars++;
                        }
                        else
                        {
                            if (car.Length <= Left_time + freeWindow)
                            {
                                totalCars++;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Accident!");
                                Console.WriteLine($"{car} was crushed at {car[Left_time + freeWindow]}.");
                                return;
                            }
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
            }
        }
    }

}