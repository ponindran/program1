using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    class grade
    {
        public static void Grade()
        {
            string notes;
            char grade;

            Console.Write("enter the grade :");
            grade = Convert.ToChar(Console.ReadLine());

            switch (grade)
            {
                case 'E':
                    notes = " Excellent";
                    break;
                case 'V':
                    notes = " Very Good";
                    break;
                case 'G':
                    notes = " Good ";
                    break;
                case 'A':
                    notes = " Average";
                    break;
                case 'F':
                    notes = " Fails";
                    break;
                default:
                    notes = "Invalid Grade.";
                    break;
            }
            Console.Write("You chosen : {0}\n", notes);

        }
    }
}
