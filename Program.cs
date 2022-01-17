using System;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
           // Indices();
           //Challenge2. PerfectNumber();
            Challenge3.Contigious();
          // Challenge3.Palindrome();
        }


        static void Indices()
        {
            int[] d = new[] { 3,1,0,11 };
            bool s = false;
            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < d.Length; j++)
                {
                    if (d[i] != d[j])
                    {
                        if (d[i] * 2 == d[j])
                        {
                            s = true;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(s);
        }
    }
}
