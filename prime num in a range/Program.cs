using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_no_in_range
{
    class Program
    {
        static void Main(string[] args)
        { int count;
            Console.WriteLine("enter a staring number");
            int startnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a ending number");
            int endingnum = Convert.ToInt32(Console.ReadLine());
             for(int i=startnum;i<=endingnum;i++)
            {
                count = 0;
                for( int j=1;j<=i; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if(count==2)
                {
                    Console.WriteLine("given number are prime number: " + i);
                }
            }
            Console.ReadLine();
        }
    }
}
        
