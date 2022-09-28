using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "My name is Rahul";
            string str2 = "Hello Rahul";
            string str3 = str1;
            int year = 2022;
            double per = 89.30;
            Console.WriteLine(str1.Length);
            Console.WriteLine(str3.Length);
            //string str4 = str1.Substring(3);
            //string str5 = str2.Substring(3, 9);

            //Console.WriteLine(str4);
            //Console.WriteLine(str5);

            Console.WriteLine(str3.GetHashCode());
            Console.WriteLine(str2.GetHashCode());

            Console.WriteLine(str1.Equals(str3));
            Console.WriteLine(str1.Equals(str2));
            string str6=string.Concat(str1," ",str2," "," ",year," ",per);
            Console.WriteLine(str6);

            char[] chrs = str1.ToCharArray(1, 10);
            foreach (var item in chrs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(str2.ToUpper());
            Console.WriteLine(str3.ToLower());
        }
    }
}
