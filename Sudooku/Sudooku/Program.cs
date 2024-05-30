



using Sudooku;

internal class Program : Sudoku_definition
{
    public static void Main(string[] args)
    {

        int[,] board = GenerateSudoku();
        PlaySudoku(board);

        // Wait for a key press before closing the console window
        Console.ReadLine();

    }
    // Sudoku generation with backtracking

}