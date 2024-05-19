using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<long> list = Console.ReadLine().Split(" ").Select(long.Parse).ToList();

        long rows = list[0];
        long columns = list[1];

        long[,] matrix = new long[rows, columns];

        if (rows > 0 && columns > 0)
        {

            for (int row = 0; row < rows; row++)
            {
                List<long> numbers = ReadFromConsole(new[] { ' ' });

                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }


            List<long> top = new List<long>();
            List<long> mid = new List<long>();
            List<long> bottom = new List<long>();

            long currentSum = 0;
            long savedSum = int.MinValue;

            List<long> savedTop = new List<long>();
            List<long> savedMid = new List<long>();
            List<long> savedBottom = new List<long>();

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < columns - 2; col++)
                {
                    currentSum = checkSquare(matrix, row, col, currentSum, top, mid, bottom);

                    if (currentSum > savedSum)
                    {
                        savedTop.Clear();
                        savedMid.Clear();
                        savedBottom.Clear();

                        savedSum = currentSum;
                        savedTop.AddRange(top);
                        savedMid.AddRange(mid);
                        savedBottom.AddRange(bottom);
                    }

                    top.Clear();
                    mid.Clear();
                    bottom.Clear();
                    currentSum = 0;
                }
            }

            long[,] newMatrix = new long[3, 3];

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (row == 0)
                    {
                        newMatrix[row, col] = savedTop[col];
                    }
                    else if (row == 1)
                    {
                        newMatrix[row, col] = savedMid[col];

                    }
                    else if (row == 2)
                    {
                        newMatrix[row, col] = savedBottom[col];
                    }
                }
            }

            Console.WriteLine($"Sum = {savedSum}");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{newMatrix[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }

    private static long checkSquare(long[,] matrix, long row, long col,
        long currentSum, List<long> top, List<long> mid, List<long> bottom)
    {
        for (long i = row; i <= row + 2; i++)
        {
            for (long j = col; j <= col + 2; j++)
            {
                currentSum += matrix[i, j];
                
                if (i == row)
                {
                    top.Add(matrix[i, j]);
                }
                else if (i == row + 1)
                {
                    mid.Add(matrix[i, j]);
                }
                else if (i == row + 2)
                {
                    bottom.Add(matrix[i,j]);
                }
            }
        }
        return currentSum;
    }
    private static List<long> ReadFromConsole(char[] separator)
    {
        return Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
    }
}