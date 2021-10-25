using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    class fibonacci
    {
        public static void Fi()
        {
            int n1 = 0, n2 = 1, n3, i;
            Console.Write("Enter the number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3+" ");
                n1 = n2;
                n2 = n3;
            }
        }
}
}
