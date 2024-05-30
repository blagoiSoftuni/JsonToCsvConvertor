int fieldSize = int.Parse(Console.ReadLine());
string[] commands = Console.ReadLine().Split();
char[][] field = new char[fieldSize][];

// Read the field
for (int row = 0; row < fieldSize; row++)
{
    field[row] = Console.ReadLine().ToCharArray();
}

int diggerRow = -1, diggerCol = -1;
int totalRocks = 0;

// Find digger's initial position and count rocks
for (int row = 0; row < fieldSize; row++)
{
    for (int col = 0; col < fieldSize; col++)
    {
        if (field[row][col] == 's')
        {
            diggerRow = row;
            diggerCol = col;
        }
        else if (field[row][col] == 'r')
        {
            totalRocks++;
        }
    }
}

// Process commands
foreach (string cmd in commands)
{
    int newRow = diggerRow, newCol = diggerCol;
    switch (cmd)
    {
        case "up":
            newRow--;
            break;
        case "down":
            newRow++;
            break;
        case "left":
            newCol--;
            break;
        case "right":
            newCol++;
            break;
    }

    // Check if new position is within bounds
    if (newRow >= 0 && newRow < fieldSize && newCol >= 0 && newCol < fieldSize)
    {
        char cell = field[newRow][newCol];
        if (cell == 'e')
        {
            Console.WriteLine($"Game over! ({diggerRow}, {diggerCol})");
            return;
        }
        else if (cell == 'r')
        {
            totalRocks--;
            field[newRow][newCol] = '*';
        }
        diggerRow = newRow;
        diggerCol = newCol;
    }
}

// Check if all rocks are collected
if (totalRocks == 0)
{
    Console.WriteLine($"All rocks are collected!! ({diggerRow}, {diggerCol})");
}
else
{
    Console.WriteLine($"{totalRocks} rocks left. ({diggerRow}, {diggerCol})");
}
    