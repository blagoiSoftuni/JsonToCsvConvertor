// See https://aka.ms/new-console-template for more information
int n = int.Parse(Console.ReadLine());

int[,] matrix = new int[n, n];
int firstSum = 0;
int secondarySum = 0;

for (int row = 0; row < n; row++)
{
    int[] rowInput = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

    for (int col = 0; col < n; col++)
    {
        matrix[row, col] = rowInput[col];
    }
}

for (int row = 0; row < n; row++)
{
    firstSum += matrix[row, row];
}
int secCol = n - 1;
for (int row = 0; row < n; row++)
{

    for (; secCol >= 0;)
    {
        secondarySum += matrix[row, secCol];
        break;
    }
    secCol--;
}

Console.WriteLine(Math.Abs(firstSum - secondarySum));
        