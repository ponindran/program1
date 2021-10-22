using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    class natutal
    {
        public static void Natutal()
        {
            int i, num, sum = 0;
            Console.Write("enter the number:");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                sum = sum + i;
                Console.Write("{0} ",i);
            }
            Console.WriteLine("\nthe sum is: {0}", sum);

        }
    }

}