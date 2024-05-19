class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 0 && n <= 30)
        {
            string[,] matrix = new string[n, n];

            Queue<string> queue = new Queue<string>();

            for (int row = 0; row < n; row++)
            {
                string text = Console.ReadLine();

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i].ToString() != " ")
                    {
                        queue.Enqueue(text[i].ToString());
                    }
                }

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = queue.Dequeue();
                }
            }

            int count = 0;
            int counter = 0;

            for (int i = 8; i > 0; i--)
            {
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (matrix[row, col] == "K")
                        {
                            if (row + 2 < n && col - 1 >= 0)
                            {
                                if (matrix[row + 2, col - 1] == "K")
                                {
                                    count++;
                                }
                            }

                            if (row + 2 < n && col + 1 < n)
                            {
                                if (matrix[row + 2, col + 1] == "K")
                                {
                                    count++;
                                }
                            }

                            if (row + 1 < n && col + 2 < n)
                            {
                                if (matrix[row + 1, col + 2] == "K")
                                {
                                    count++;
                                }
                            }

                            if (row + 1 < n && col - 2 >= 0)
                            {
                                if (matrix[row + 1, col - 2] == "K")
                                {
                                    count++;
                                }
                            }

                            if (row - 1 >= 0 && col - 2 >= 0)
                            {
                                if (matrix[row - 1, col - 2] == "K")
                                {
                                    count++;
                                }
                            }

                            if (row - 1 >= 0 && col + 2 < n)
                            {
                                if (matrix[row - 1, col + 2] == "K")
                                {
                                    count++;
                                }
                            }

                            if (row - 2 >= 0 && col - 1 >= 0)
                            {
                                if (matrix[row - 2, col - 1] == "K")
                                {
                                    count++;
                                }
                            }

                            if (row - 2 >= 0 && col + 1 < n)
                            {
                                if (matrix[row - 2, col + 1] == "K")
                                {
                                    count++;
                                }
                            }

                            if (count == i)
                            {
                                matrix[row, col] = "0";
                                counter++;
                            }

                            count = 0;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}