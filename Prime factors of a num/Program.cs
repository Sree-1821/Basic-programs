using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_factors_of_a_num
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count = 0;
                    for( int j=1;j<=i;j++)
                    {
                        if(i%j==0)
                        count++;
                    }
                    if(count==2)
                    {
                        Console.WriteLine("prime factors :" + i);
                        Console.ReadLine();

                    }
                }
                

            }
        }
    }
}
