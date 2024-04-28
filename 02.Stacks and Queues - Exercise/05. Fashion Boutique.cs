class Program
{
    static void Main(string[] args)
    {
        Stack<int> sequenceOfIntegers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
        Stack<int> newSequenceOfIntegers = new Stack<int>(sequenceOfIntegers);

        int capacity = int.Parse(Console.ReadLine());
        ;
        int result = 0;
        int count = 0;
        int currentCapacity = capacity;

        if (newSequenceOfIntegers.Any())
        {
            if (newSequenceOfIntegers.Peek() > 0)
            {
                count++;
            }
        }

        while (newSequenceOfIntegers.Any())
        {
            result = newSequenceOfIntegers.Peek();

            if (result <= currentCapacity)
            {
                currentCapacity -= result;
                newSequenceOfIntegers.Pop();
            }
            else
            {
                result = newSequenceOfIntegers.Pop();
                currentCapacity = capacity - result;
                count++;
            }
        }
        
        Console.WriteLine(count);
    }
}