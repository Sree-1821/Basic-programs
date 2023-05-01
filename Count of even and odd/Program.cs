using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_odf_even__odd_use_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("eneter a array size");
            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[size];
            //Console.WriteLine("array elements");
            //int evencount = 0, oddcount = 0;
            //for(int i=0;i<=arr.Length;i++)
            //{
            //    if(arr[i]%2==0)
            //    {
            //        evencount++;
            //    }
            //    else
            //    {
            //        oddcount++;
            //    }
            //    Console.WriteLine(evencount);
            //    Console.WriteLine(oddcount);
            //}
            int[] arr = new int[100];
            int i, num, evennum, oddnum;

            ////Reads size and elements in array
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + num + " elements in the array: ");

            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            evennum = 0; // Assuming 0 even numbers
            oddnum = 0; // Assuming 0 odd numbers

            for (i = 0; i < num; i++)
            {
                /* If the current element of array is evennumber then increment evennumber count */
                if (arr[i] % 2 == 0)
                {
                    evennum++;
                }
                else
                {
                    oddnum++; // increment oddnumber count
                }
            }

            Console.WriteLine("Total even  numbers: " + evennum);
            Console.WriteLine("Total odd numbers: " + oddnum);


            Console.ReadLine();
        }

    }
}
    

