using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_in_a_range
{
    class Program
    {
        static void Main(string[] args)
        {
            //int temp, sum = 0, reminder;
            //Console.WriteLine("enter a starting number");
            //int startnum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter a a ending number");
            //int endingnum = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Armstrong numbers in given range are: ");

            //for (int i = startnum; i <= endingnum; i++)
            //{

            //    temp = i;
            //    while (temp != 0)

            //        reminder = i % 10;
            //          sum = sum + (reminder * reminder * reminder);
            //    i = i / 10;
            //}


            //    if (sum == i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.ReadLine();

            Console.Write("Input starting number of range: ");
            int startnum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input ending number of range : ");
            int endingnum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Armstrong numbers in given range are: ");
            int num, temp, sum, reminder;
            for (num = startnum; num <= endingnum; num++)
            {
                temp = num;
                sum = 0;

                while (temp != 0)
                {
                    reminder = temp % 10;
                    sum = sum + (reminder * reminder * reminder);
                    temp = temp / 10;

                }
                if (sum == num)
                    Console.Write("{0} ", num);
            }
            Console.ReadLine();
        }
    }
}

