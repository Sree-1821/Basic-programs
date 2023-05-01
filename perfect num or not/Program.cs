using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_or_not
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.Write("enter the Number");
            int  number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n Entered number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
                Console.ReadLine();
            }
        }
    }
}
