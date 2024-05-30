namespace task33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the quantity of orders:");
            if (int.TryParse(Console.ReadLine(), out int quantity))
            {
                Stack<int> orders = new Stack<int>();

                Console.WriteLine("Enter the orders separated by space:");
                string[] orderValues = Console.ReadLine().Split(' ');

                // Parsing order values into the stack
                foreach (var orderValue in orderValues)
                {
                    if (int.TryParse(orderValue, out int order))
                    {
                        orders.Push(order);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter valid integers.");
                        return;
                    }
                }

                // Finding and printing the maximum order value
                int maxOrder = FindMaxOrder(orders);
                Console.WriteLine($"Max Order: {maxOrder}");

                // Printing the remaining orders without the max number
                PrintRemainingOrders(orders, maxOrder);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for quantity.");
            }
        }

        static int FindMaxOrder(Stack<int> orders)
        {
            int maxOrder = int.MinValue;

            foreach (var order in orders)
            {
                if (order > maxOrder)
                {
                    maxOrder = order;
                }
            }

            return maxOrder;
        }

        static void PrintRemainingOrders(Stack<int> orders, int maxOrder)
        {
            Console.Write("Remaining Orders after Max: ");
            bool foundMax = false;

            foreach (var order in orders)
            {
                if (foundMax)
                {
                    Console.Write($"{order} ");
                }

                if (order == maxOrder)
                {
                    foundMax = true;
                }
            }
            Console.WriteLine();
        }
    }

}
    