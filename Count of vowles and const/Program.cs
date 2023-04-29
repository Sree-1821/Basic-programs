using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_vowles_and_con
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter  a string");
            string result = Console.ReadLine();
            string str = result.ToLower();
            int vcount = 0, ccount = 0, nonalpha = 0;

            for (int i =0;i<str.Length;i++)
            {
                if (str[i] > 'a' && str[i] < 'z')
                {
                    if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                    {
                        vcount++;

                    }
                    else
                    {
                        ccount++;
                    }
                }
                else
                {
                    nonalpha++;
                }
                  
                }
            Console.WriteLine( "no of vowles : "  + vcount);
            Console.WriteLine("no of Const : " + ccount);
            Console.WriteLine("no of nonalpha : " + nonalpha);


            Console.ReadLine();
            
            }
        
       

        }
    }

