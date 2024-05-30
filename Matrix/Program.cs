namespace Matrix
{
    internal class Program
    {
        private static int CountEqual2x2Squares(int rows, int cols, char[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] &&
                        matrix[i, j] == matrix[i + 1, j] &&
                        matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        count++;
                    }

                    return count;

                }
            }
        }

        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split();
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);

            char[,] matrix = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] rowValues = Console.ReadLine().Split();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rowValues[j][0];
                }
            }

            int result = CountEqual2x2Squares(rows, cols, matrix);
            Console.WriteLine(result);
        }

    }
}
