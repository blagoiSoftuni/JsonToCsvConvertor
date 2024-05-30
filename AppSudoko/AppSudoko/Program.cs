// See https://aka.ms/new-console-template for more information
namespace Sudoku
{
    using System;
    using System.Collections.Generic;
    internal class SudokuGame
    {
        static void Main()
        {
            int[,] board = GenerateSudoku();
            PlaySudoku(board);

            // Wait for a key press before closing the console window
            Console.ReadLine();
        }

        // Sudoku generation with backtracking
        static bool GenerateSudokuHelper(int[,] board)
        {
            Random random = new Random();

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col] == 0)
                    {
                        List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                        Shuffle(nums);

                        foreach (int num in nums)
                        {
                            if (IsValidMove(board, row, col, num))
                            {
                                board[row, col] = num;

                                if (GenerateSudokuHelper(board))
                                    return true;

                                board[row, col] = 0;
                            }
                        }

                        return false; // No valid move
                    }
                }
            }

            return true; // Sudoku generated successfully
        }
        static void Shuffle<T>(List<T> list)
        {
            Random random = new Random();
            int n = list.Count;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }

        // Generate initial Sudoku state
        static int[,] GenerateSudoku()
        {
            int[,] sudoku = new int[9, 9];
            GenerateSudokuHelper(sudoku);
            return sudoku;
        }

        // Check the validity of a move
        static bool IsValidMove(int[,] board, int row, int col, int num)
        {
            return IsRowValid(board, row, num) && IsColValid(board, col, num) && IsBoxValid(board, row - row % 3, col - col % 3, num);
        }

        // Check the validity of numbers in a row
        static bool IsRowValid(int[,] board, int row, int num)
        {
            for (int col = 0; col < 9; col++)
            {
                if (board[row, col] == num)
                    return false;
            }
            return true;
        }

        // Check the validity of numbers in a column
        static bool IsColValid(int[,] board, int col, int num)
        {
            for (int row = 0; row < 9; row++)
            {
                if (board[row, col] == num)
                    return false;
            }
            return true;
        }

        // Check the validity of numbers in a 3x3 box
        static bool IsBoxValid(int[,] board, int startRow, int startCol, int num)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[startRow + row, startCol + col] == num)
                        return false;
                }
            }
            return true;
        }

        // Check if Sudoku is solved (no empty cells)
        static bool IsSudokuSolved(int[,] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col] == 0)
                        return false;
                }
            }
            return true;
        }

        // Display the state of Sudoku
        static void PrintBoard(int[,] board)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(board[i, j] == 0 ? "  " : $"{board[i, j]} ");
                    if (j == 2 || j == 5) Console.Write("| ");
                }

                Console.WriteLine();

                if (i == 2 || i == 5)
                    Console.WriteLine("------+-------+------");
            }
            Console.WriteLine();
        }

        // Remove numbers from Sudoku to adjust difficulty
        static void RemoveNumbers(int[,] board, int count)
        {
            Random random = new Random();

            while (count > 0)
            {
                int row = random.Next(9);
                int col = random.Next(9);

                if (board[row, col] != 0)
                {
                    int temp = board[row, col];
                    board[row, col] = 0;

                    // Check if only one possible number is left to fill
                    if (!IsValidMove(board, row, col, temp) || !IsUniqueSolution(board))
                    {
                        board[row, col] = temp; // Restore the number
                        count--;
                    }
                    else
                    {
                        count--;
                    }
                }
            }
        }

        // Check if there is a unique solution for Sudoku
        static bool IsUniqueSolution(int[,] board)
        {
            int[,] tempBoard = new int[9, 9];
            Array.Copy(board, tempBoard, board.Length);
            return SolveSudoku(tempBoard);
        }

        // Solve Sudoku using backtracking
        static bool SolveSudoku(int[,] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row, col] == 0)
                    {
                        for (int num = 1; num <= 9; num++)
                        {
                            if (IsValidMove(board, row, col, num))
                            {
                                board[row, col] = num;

                                if (SolveSudoku(board))
                                    return true;

                                board[row, col] = 0;
                            }
                        }

                        return false; // No valid move
                    }
                }
            }

            return true; // Sudoku solved successfully
        }
    }
}
