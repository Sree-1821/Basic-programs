using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COUNT_OF_DIGITS_IN_INTEGER
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int reminder, count = 0;
            while(number>0)
            {
                reminder = number % 10;
                count++;
                number = number / 10;
            }
            Console.WriteLine("total digits are :" +count);
            Console.ReadLine();
        }
    }
}
