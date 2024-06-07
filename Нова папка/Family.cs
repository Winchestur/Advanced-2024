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

        public static void GetOldestMember()
        {
            string name = "";
            int currentOlderPerson = int.MinValue;
            foreach (var item in Members)
            {
                if (currentOlderPerson < item.Age)
                {
                    name = item.Name;
                    currentOlderPerson = item.Age;
                }
            }

            Console.WriteLine($"{name} {currentOlderPerson}");
        }
    }
}