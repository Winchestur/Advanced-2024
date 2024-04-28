using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        StringBuilder sb = new StringBuilder();
        List<string> saves = new List<string>();

        for (int i = 0; i < n; i++)
        {
            List<string> commands = Console.ReadLine().Split().ToList();

            switch (commands[0])
            {
                case "1":
                    sb.Append(commands[1]);
                    saves.Add(sb.ToString());
                    break;
                case "2":

                    if (int.Parse(commands[1]) < sb.Length)
                    {
                        int length = sb.Length - int.Parse(commands[1]);
                        for (int j = sb.Length - 1; j >= length; j--)
                        {
                            sb.Remove(sb.Length-1, sb.Length - j);
                        }
                        saves.Add(sb.ToString());
                    }
                    else
                    {
                        sb.Clear();
                        saves.Add(sb.ToString());
                    }

                    break;
                case "3":
                    for (int j = 0; j < sb.Length; j++)
                    {
                        if (j == int.Parse(commands[1])-1)
                        {
                            Console.WriteLine(sb[j].ToString());
                        }
                    }
                    break;
                case "4":
                    saves.RemoveAt(saves.Count-1);
                    sb.Clear();
                    if (saves.Count > 0)
                    {
                        sb.Append(saves[saves.Count - 1]);
                    }
                    else
                    {
                        sb.Append("");
                    }

                    break;
            }
        }
    }
}