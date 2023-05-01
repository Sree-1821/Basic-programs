using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, reminder, temp;
            Console.WriteLine("enter a number");
            int  num = Convert.ToInt32(Console.ReadLine());
            temp = num;

            while (num > 0)

            {
                reminder = num % 10;
                sum = sum + (reminder * reminder * reminder);
                num = num / 10;

            }
            if(temp==sum)
            {
                Console.WriteLine("given number is Armstrong  " );
            }
            else
            {
                Console.WriteLine("not Armstrong");
            }
            Console.ReadLine();

        }
    }
}
