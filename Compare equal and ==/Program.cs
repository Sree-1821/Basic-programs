using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare_equal_method__and_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello",str2 = "Hello",str3 = "hello";

            Console.WriteLine(str1 == str2); // true           == check the location memory or addresss of memory
            Console.WriteLine(str1 == str3); // false

            Console.WriteLine(str1.Equals(str2));// true       it checks the content
            Console.WriteLine(str1.Equals(str3));// false
            Console.ReadLine();

        }
}
}
