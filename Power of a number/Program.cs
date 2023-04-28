using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace power_of_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a base  number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a expo number");
            int x = Convert.ToInt32(Console.ReadLine());

            int result = 1;
            for (int i = 1; i <= x; i++)
            {
                result = result * n;
            }

                Console.WriteLine(result);
            Console.ReadLine();

        }

    }
    }
    

