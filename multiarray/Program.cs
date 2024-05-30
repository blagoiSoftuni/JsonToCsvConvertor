// See https://aka.ms/new-console-template for more information

int[] input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

int[,] matrix = new int[input[0], input[1]];
int rows = input[0];
int cols = input[1];
int sum = 0;
for (int row = 0; row < rows; row++)
{
    int[] data = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();

    for (int col = 0; col < cols; col++)
    {
        matrix[row, col] = data[col];
        sum += data[col];
    }
    Console.WriteLine("The rows are:" + rows);
    Console.WriteLine("The cows are" + cols);
    Console.WriteLine("The sum is:" + sum);
}
       