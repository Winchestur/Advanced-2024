using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<string> list = Console.ReadLine().Split().ToList();
                string name = list[0];
                int age = int.Parse(list[1]);
                Person person = new Person(name, age);

                Family.AddMember(person);
            }
            Family.GetOlderPeople();
        }
    }
}