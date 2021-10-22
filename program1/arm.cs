using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    class arm
    {
        public static void armstrong()
        {
            int n, r, temp, sum = 0;
            Console.Write("enter the number:");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while(n>0)
            {
                r = n % 10;
                sum = sum + (r * r * r) ;
                n = n / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("the num is armstrong");
            }
            else
            {
                Console.WriteLine("the num is not armstrong");
            }

        }
    }
}
