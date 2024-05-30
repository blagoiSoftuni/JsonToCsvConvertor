// See https://aka.ms/new-console-template for more information

int quantity = int.Parse(Console.ReadLine());
int[] orders = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();


for (int i = 0; i < orders.Length; i++) {
    stack.Push(orders[i]);
}
Console.WriteLine (stack.Max());
int quantityOfFood = int.Parse(Console.ReadLine());


Queue<int> queue = new Queue<int>(orders);
int biggestOrder = queue.Max();
int queueNum = orders.Count();

for (int customer = 0; customer < queueNum; customer++)
{
    if (queue.Sum() == quantity)
    {
        Console.WriteLine(biggestOrder);
        Console.WriteLine("All orders are completed");
    }
    if (quantityOfFood - queue.Peek() < 0)
    {
        Console.WriteLine(biggestOrder);
        Console.Write($"Orders left:");
       
        
        for (int j = customer; j <= queueNum; customer++)
        {
            if (customer == queueNum)
            {
                Console.WriteLine("All orders are completed");  
            } else {
                foreach (var item in queue)
                {
                    Console.WriteLine(queue(item) > biggestOrder);
                }
            }

            Console.Write(" " + orders[customer]);
        }
    }

    quantityOfFood -= queue.Peek();
    queue.Enqueue(queue.Dequeue());
}
if (stack.Sum() == quantity) { 
Console.WriteLine(biggestOrder);
Console.WriteLine("All orders are completed");
        }
    
