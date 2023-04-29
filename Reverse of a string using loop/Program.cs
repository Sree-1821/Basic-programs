using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_string_using_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            for(int i=str.Length;i>0;i--)  // sree=lenth =4 ,4>0
            {
                Console.Write(str[i-1]);
            }
            Console.ReadLine();
        }
    }
}
