using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    class oddnatural
    {
        public static void odd()
        {

            int i, num, sum = 0;
            Console.Write("enter the number:");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum = sum + 2 * i - 1;
             }

            Console.WriteLine("\nthe sum is: {0}", sum);
        }
    }
}