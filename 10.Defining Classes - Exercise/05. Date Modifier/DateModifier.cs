using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProgram
{
    public class DateModifier
    {
        public static DateTime FirstDate { get; set; }
        public static DateTime LastDate { get; set; }

        public DateModifier(DateTime first , DateTime second)
        {
            FirstDate = first.Date;
            LastDate = second.Date;
        }


        public static void print()
        {
            TimeSpan days = FirstDate - LastDate;
            Console.WriteLine(Math.Abs(days.Days));
        }
    }
}
