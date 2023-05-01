using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp ,reminder ,sum=0;
            Console.WriteLine("enter a  number");
            int num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while(num>0)  // 145>0
            {
                reminder = num % 10;
                int fact = 1;//145%10=5,14%10=4
                for(int i=1;i<=reminder;i++)                 

                {
                    fact = fact * i;  // 1*1,2*1,2*3,6*4,24*5,    24  ,1
                }
                sum = sum + fact;  //0+120=120,  120+24=144,   144+1=145
                num = num / 10;//14,   1
                
            }
            if(sum==temp)
            {
                Console.WriteLine("given number is strong");
            }
            else
            {
                Console.WriteLine("not strong num");
            }
            Console.ReadLine();


        }
    }
}
