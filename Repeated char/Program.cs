using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reprated_charchters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            while(str.Length>0)
            {
                int countofchar = 0;
                Console.WriteLine(str[0]);
                for(int i=0;i<str.Length;i++)
                {
                    if(str[0]==str[i])
                    {
                        countofchar++;

                    }
                }
                Console.WriteLine(countofchar);
                str = str.Replace(str[0].ToString(), string.Empty);

            }
            Console.ReadLine();

        }
    }
}
