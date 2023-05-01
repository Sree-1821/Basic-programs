using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avg_of_a_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double avg;
            Console.WriteLine("enter a  10 number");
            //int num = Convert.ToInt32(Console.ReadLine());
            for(int i=11;i<=20;i++)
            {
                sum = sum + i;
                Console.WriteLine("sum is :" +sum);
                
            }
            avg = sum / 10;
            Console.WriteLine(" avg is :" +avg);
            Console.ReadLine();
            
        }
    }
}
