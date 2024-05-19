class Program
{
    static void Main(string[] args)
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

        int rows = list[0];
        int columns = list[1];

        string[,] matrix = new string[rows,columns];

        for (int row = 0; row < rows; row++)
        {
            List<string> nums = Console.ReadLine().Split().ToList();

            for (int col = 0; col < columns; col++)
            {
                matrix[row,col] = nums[col];
            }
        }

        List<string> commands = Console.ReadLine().Split().ToList();

        while (commands[0] != "END")
        {
            if (commands[0] == "swap")
            {
                if (commands.Count == 5)
                {
                    Swap(matrix, commands, rows, columns);
                }

                else
                {
                    Console.WriteLine($"Invalid input!");   
                }
            }
            else
            {
                Console.WriteLine($"Invalid input!");
            }

            commands = Console.ReadLine().Split().ToList();
        }
    }
    private static void Print(int rows, int columns, string[,] matrix)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < columns; col++)
            {
                Console.Write($"{matrix[row,col]} ");
            }
            Console.WriteLine();
        }
    }
    private static void Swap(string[,] matrix, List<string> commands, int rows, int columns)
    {
        int row1 = int.Parse(commands[1]);
        int col1 = int.Parse(commands[2]);
        int row2 = int.Parse(commands[3]);
        int col2 = int.Parse(commands[4]);

        if (row1 >= 0 && row1 < matrix.GetLength(0) &&
            col1 >= 0 && col1 < matrix.GetLength(1) &&
            row2 >= 0 && row2 < matrix.GetLength(0) &&
            col2 >= 0 && col2 < matrix.GetLength(1))
        {

            string takeFirstNum = "";
            string TakeSecondNum = "";

            takeFirstNum = matrix[row1, col1];
            TakeSecondNum = matrix[row2, col2];

            matrix[row1, col1] = TakeSecondNum;
            matrix[row2, col2] = takeFirstNum;

            Print(rows, columns, matrix);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}