using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_year_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a year");
            int year = Convert.ToInt32(Console.ReadLine());
            if((year%4==0)&&(year%100!=0)||(year%400==0))
            {
                Console.WriteLine("Given year is leap year");

            }
            else
            {
                Console.WriteLine("Given year is not a leap year");
            }
            Console.ReadLine();
        }
    }
}
