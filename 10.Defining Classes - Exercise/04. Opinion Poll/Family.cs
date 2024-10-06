using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Family
    {
        public static List<Person> Members = new List<Person>();

        public static void AddMember(Person member)
        {
            Members.Add(member);
        }

        public static void GetOlderPeople()
        {
            foreach (var item in Members.OrderBy(n=>n.Name))
            {
                if (item.Age > 30)
                {
                    Console.WriteLine($"{item.Name} - {item.Age}");
                }
            }
        }
    }
}