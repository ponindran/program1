using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    class month
    {
        public static void Moth()
        {
            Console.Write("Input Month No : ");
            int monthno = Convert.ToInt32(Console.ReadLine());
            switch (monthno)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Month  have 31 days. ");
                    break;
                case 2:
                    Console.WriteLine("The 2nd month is a February and have 28 days. ");
                    Console.WriteLine("in leap year The February month  Have 29 days.");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Month have 30 days.");
                    break;
                default:
                    Console.WriteLine("invalid Month number.\nPlease try again ....");
                    break;
            }
        }
    }
}
