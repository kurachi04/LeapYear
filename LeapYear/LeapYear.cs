using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    public class LeapYear
    {
        public int Year { get; set; }

        /*
        public LeapYear(int year)
        {
            this.Year = year;
        }
        */

        public void LeapYearCount()
        {
            if (Year % 4 == 0)
            {
                Console.WriteLine("{0}是閏年", Year);
            }
            else
            {
                Console.WriteLine("{0}不是閏年", Year);
            }
        }
    }
}