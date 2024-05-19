class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        for (int row = 0; row < n; row++)
        {
            List<int> nums = Console.ReadLine().Split(" ",
                    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToList();

            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = nums[col];
            }
        }

        Queue<string> queue = new Queue<string>(Console.ReadLine().Split(new char[] { ' ', ',' },
            StringSplitOptions.RemoveEmptyEntries));

        int length = queue.Count / 2;

        int bombRow = 0;
        int bombCol = 0;

        for (int i = 0; i < length; i++)
        {
            bombRow = int.Parse(queue.Dequeue());
            bombCol = int.Parse(queue.Dequeue());

            if (bombRow >= 0 && bombRow < n && bombCol >= 0 && bombCol < n)
            {
                int bombNumber = 0;

                if (matrix[bombRow, bombCol] > 0)
                {
                    bombNumber = matrix[bombRow, bombCol];
                    matrix[bombRow, bombCol] = 0;
                }

                if (bombNumber > 0)
                {
                    FirstRow(matrix, n, bombRow, bombCol, bombNumber);

                    MidRow(matrix, n, bombRow, bombCol, bombNumber);

                    LastRow(matrix, n, bombRow, bombCol, bombNumber);
                }
            }
        }

        int countAliveCells = 0;
        int sum = 0;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (matrix[row, col] > 0)
                {
                    countAliveCells++;
                    sum += matrix[row, col];
                }
            }
        }

        Console.WriteLine($"Alive cells: {countAliveCells}");
        Console.WriteLine($"Sum: {sum}");

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (row == n - 1 && col == n - 1)
                {
                    Console.WriteLine(matrix[row, col]);
                }
                else
                {
                    Console.Write($"{matrix[row, col]} ");
                }
            }
            Console.WriteLine();
        }
    }
    private static void FirstRow(int[,] matrix, int n, int bombRow, int bombCol, int bombNumber)
    {
        // check if row is equal to 0 and if column is equal to 0
        if (bombRow == 0 && bombCol == 0)
        {
            if (matrix[bombRow, bombCol + 1] > 0)
                matrix[bombRow, bombCol + 1] -= bombNumber;

            if (matrix[bombRow + 1, bombCol] > 0)
                matrix[bombRow + 1, bombCol] -= bombNumber;

            if (matrix[bombRow + 1, bombCol + 1] > 0)
                matrix[bombRow + 1, bombCol + 1] -= bombNumber;
        }

        // check if row is equal to 0 and if column is bigger than 0 and if its lower than n - 1
        if (bombRow == 0 && bombCol > 0 && bombCol < n - 1)
        {
            if (matrix[bombRow, bombCol - 1] > 0)
                matrix[bombRow, bombCol - 1] -= bombNumber;

            if (matrix[bombRow, bombCol + 1] > 0)
                matrix[bombRow, bombCol + 1] -= bombNumber;

            if (matrix[bombRow + 1, bombCol - 1] > 0)
                matrix[bombRow + 1, bombCol - 1] -= bombNumber;

            if (matrix[bombRow + 1, bombCol] > 0)
                matrix[bombRow + 1, bombCol] -= bombNumber;

            if (matrix[bombRow + 1, bombCol + 1] > 0)
                matrix[bombRow + 1, bombCol + 1] -= bombNumber;
        }

        // check if row is equal to 0 and if column is equal to n - 1
        if (bombRow == 0 && bombCol == n - 1)
        {
            if (matrix[bombRow, bombCol - 1] > 0)
                matrix[bombRow, bombCol - 1] -= bombNumber;

            if (matrix[bombRow + 1, bombCol - 1] > 0)
                matrix[bombRow + 1, bombCol - 1] -= bombNumber;

            if (matrix[bombRow + 1, bombCol] > 0)
                matrix[bombRow + 1, bombCol] -= bombNumber;
        }
    }
    private static void MidRow(int[,] matrix, int n, int bombRow, int bombCol, int bombNumber)
    {
        // check if row is bigger than 0 and if its lower than n - 1 and if column is equals to 0
        if (bombRow > 0 && bombRow < n - 1 && bombCol == 0)
        {
            if (matrix[bombRow - 1, bombCol] > 0)
                matrix[bombRow - 1, bombCol] -= bombNumber;

            if (matrix[bombRow - 1, bombCol + 1] > 0)
                matrix[bombRow - 1, bombCol + 1] -= bombNumber;

            if (matrix[bombRow, bombCol + 1] > 0)
                matrix[bombRow, bombCol + 1] -= bombNumber;

            if (matrix[bombRow + 1, bombCol] > 0)
                matrix[bombRow + 1, bombCol] -= bombNumber;

            if (matrix[bombRow + 1, bombCol + 1] > 0)
                matrix[bombRow + 1, bombCol + 1] -= bombNumber;
        }

        // check if row is bigger than 0 and if its lower than n - 1 and if column is bigger than 0 and if its lower than n - 1
        if (bombRow > 0 && bombRow < n - 1 && bombCol > 0 && bombCol < n - 1)
        {
            if (matrix[bombRow - 1, bombCol - 1] > 0)
                matrix[bombRow - 1, bombCol - 1] -= bombNumber;

            if (matrix[bombRow - 1, bombCol] > 0)
                matrix[bombRow - 1, bombCol] -= bombNumber;

            if (matrix[bombRow - 1, bombCol + 1] > 0)
                matrix[bombRow - 1, bombCol + 1] -= bombNumber;

            if (matrix[bombRow, bombCol - 1] > 0)
                matrix[bombRow, bombCol - 1] -= bombNumber;

            if (matrix[bombRow, bombCol + 1] > 0)
                matrix[bombRow, bombCol + 1] -= bombNumber;

            if (matrix[bombRow + 1, bombCol - 1] > 0)
                matrix[bombRow + 1, bombCol - 1] -= bombNumber;

            if (matrix[bombRow + 1, bombCol] > 0)
                matrix[bombRow + 1, bombCol] -= bombNumber;

            if (matrix[bombRow + 1, bombCol + 1] > 0)
                matrix[bombRow + 1, bombCol + 1] -= bombNumber;
        }

        // check if row is bigger than 0 and if its lower than n - 1 and if column is equal to n - 1
        if (bombRow > 0 && bombRow < n - 1 && bombCol == n - 1)
        {
            if (matrix[bombRow - 1, bombCol - 1] > 0)
                matrix[bombRow - 1, bombCol - 1] -= bombNumber;

            if (matrix[bombRow - 1, bombCol] > 0)
                matrix[bombRow - 1, bombCol] -= bombNumber;

            if (matrix[bombRow, bombCol - 1] > 0)
                matrix[bombRow, bombCol - 1] -= bombNumber;

            if (matrix[bombRow + 1, bombCol - 1] > 0)
                matrix[bombRow + 1, bombCol - 1] -= bombNumber;

            if (matrix[bombRow + 1, bombCol] > 0)
                matrix[bombRow + 1, bombCol] -= bombNumber;
        }
    }
    private static void LastRow(int[,] matrix, int n, int bombRow, int bombCol, int bombNumber)
    {
        //check if row is equal to n - 1 and if column is equal to 0
        if (bombRow == n - 1 && bombCol == 0)
        {
            if (matrix[bombRow - 1, bombCol] > 0)
                matrix[bombRow - 1, bombCol] -= bombNumber;

            if (matrix[bombRow - 1, bombCol + 1] > 0)
                matrix[bombRow - 1, bombCol + 1] -= bombNumber;

            if (matrix[bombRow, bombCol + 1] > 0)
                matrix[bombRow, bombCol + 1] -= bombNumber;
        }

        //check if row is equal to n - 1 and if column is bigger than 0 and if its lower than n - 1
        if (bombRow == n - 1 && bombCol > 0 && bombCol < n - 1)
        {
            if (matrix[bombRow - 1, bombCol - 1] > 0)
                matrix[bombRow - 1, bombCol - 1] -= bombNumber;

            if (matrix[bombRow - 1, bombCol] > 0)
                matrix[bombRow - 1, bombCol] -= bombNumber;

            if (matrix[bombRow - 1, bombCol + 1] > 0)
                matrix[bombRow - 1, bombCol + 1] -= bombNumber;

            if (matrix[bombRow, bombCol - 1] > 0)
                matrix[bombRow, bombCol - 1] -= bombNumber;

            if (matrix[bombRow, bombCol + 1] > 0)
                matrix[bombRow, bombCol + 1] -= bombNumber;
        }

        //check if row is equal to n - 1 and if column is equal to n - 1
        if (bombRow == n - 1 && bombCol == n - 1)
        {
            if (matrix[bombRow - 1, bombCol - 1] > 0)
                matrix[bombRow - 1, bombCol - 1] -= bombNumber;

            if (matrix[bombRow - 1, bombCol] > 0)
                matrix[bombRow - 1, bombCol] -= bombNumber;

            if (matrix[bombRow, bombCol - 1] > 0)
                matrix[bombRow, bombCol - 1] -= bombNumber;
        }
    }
}