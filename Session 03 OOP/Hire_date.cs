using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03_OOP
{
    using System;
    using System.Globalization;

    public class Hire_date
    {
        public int Day { get; private set; }
        public int Month { get; private set; }
        public int Year { get; private set; }

        public Hire_date(int day, int month, int year)
        {

            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $" The Hire_date is : {Day:00}/{Month:00}/{Year}";
        }
   
    }

}
