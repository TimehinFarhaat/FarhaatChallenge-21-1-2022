using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    class Challenge2
    {
      public  static void PerfectNumber()
      {
            bool d = false;
            int num = 2;
            int y = 1;

            for (int i = 2; i <= (num / 2); i++)
            {
                if (num % i == 0)
                {
                    y += i;
                }

            }

            if (y==num)
            {
                d = true;
            Console.WriteLine(d);
            }
      }
    }
}

