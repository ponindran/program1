using System;
using System.Collections.Generic;
using System.Text;

namespace program1
{
    class assending
    {
      public static void Ass()
        {
            int[] arr = new int[] { 9, 4, 5, 6, 1 };

            Array.Sort(arr);

            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }
        }

    }
}
