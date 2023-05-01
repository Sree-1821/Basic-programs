using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringlength
{
    class Program
    {
        static void Main(string[] args)
        {
            int count =0;
            Console.WriteLine("enter a string");
            string str=  Console.ReadLine();
            for(int i=0; str[i]!=0;i++)
            {
                count++;
            }
            
                 
            
            
                Console.WriteLine( " Length is :" + count);

            
            Console.ReadLine();
        }

    }
}
