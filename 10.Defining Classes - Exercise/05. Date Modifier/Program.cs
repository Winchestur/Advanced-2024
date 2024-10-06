using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProgram
{
    public class Program
    {
         static void Main()
        {
            DateTime firstDateTime = DateTime.Parse(Console.ReadLine());

            DateTime secondDateTime = DateTime.Parse(Console.ReadLine());

            DateModifier dates = new DateModifier(firstDateTime, secondDateTime);

            DateModifier.print();
        }
    }
}

