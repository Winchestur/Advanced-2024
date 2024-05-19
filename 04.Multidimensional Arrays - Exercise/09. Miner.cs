class Program
{ 
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<string> commands = Console.ReadLine().Split(" " ,
            StringSplitOptions.RemoveEmptyEntries).ToList();

        string[,] matrix = new string[n,n];

        List<int> startingPlace = new List<int>();

        int countCoals = 0;

        countCoals = InsertInMatrix(matrix, n, startingPlace, countCoals);

        for (int i = 0; i < commands.Count; i++)
        {
            int row = 0;
            int col = 0;

            if (startingPlace[0] >= 0 && startingPlace[0] < n && startingPlace[1] >= 0 && startingPlace[1] < n)
            {
                row = startingPlace[0];
                col = startingPlace[1];
            }

            switch (commands[i])
            {
                case "up":
                    if (row - 1 >= 0)
                    {
                       countCoals = Directions(matrix, n, row - 1, col, countCoals, startingPlace);
                    }
                    break;
                case "down":
                    if (row + 1 < n)
                    {
                       countCoals = Directions(matrix, n, row + 1, col, countCoals, startingPlace);
                    }
                    break;
                case "left":
                    if (col - 1 >= 0)
                    {
                       countCoals = Directions(matrix, n, row, col - 1, countCoals, startingPlace);
                    }
                    break;
                case "right":
                    if (col + 1 < n)
                    {
                       countCoals = Directions(matrix, n, row, col + 1, countCoals, startingPlace);
                    }
                    break;
            }

            if (matrix[startingPlace[0], startingPlace[1]] == "e")
            {
                return;
            }

            if (countCoals == 0)
            {
                Console.WriteLine($"You collected all coals! ({startingPlace[0]}, {startingPlace[1]})");
                return;
            }
        }

        if (countCoals > 0)
        {
            Console.WriteLine($"{countCoals} coals left. ({startingPlace[0]}," +
                              $" {startingPlace[1]})");
        }
    }
    private static int Directions(string[,] matrix, int n, int row, int col, int countCoals, List<int> startingPlace)
    {
        switch (matrix[row, col])
        {
            case "*":
                startingPlace[0] = row;
                startingPlace[1] = col;
                break;
            case "c":
                startingPlace[0] = row;
                startingPlace[1] = col;

                countCoals--;

                matrix[row, col] = "*";
                break;
            case "e":
                startingPlace[0] = row;
                startingPlace[1] = col;
                Console.WriteLine($"Game over! ({row}, {col})");
                break;
        }
        return countCoals;
    }
    private static int InsertInMatrix(string[,] matrix, int n , List<int> startingPlace, int countCoals)
    {
        for (int row = 0; row < n; row++)
        {
            List<string> characters = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = characters[col];

                if (matrix[row, col] == "s")
                {
                    startingPlace.Add(row);
                    startingPlace.Add(col);
                }

                if (matrix[row, col] == "c")
                {
                    countCoals++;
                }
            }
        }
        return countCoals;
    }
}