using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;

namespace Code
{
    class Challenge3
    {
      public static void Contigious()
      {
          int[] sum = new[] {5};
          int k = 1;
          int so=0;
          float l = 0;
          for (int i = 0; i <= sum.Length - k; i++)
          {
              so = 0;
              for (int j = i; j < k + i; j++)
              {
                  so += sum[j];

              }

              if (so > l )
              {
                  l = so ;
              }
          }
          Console.WriteLine((l / k).ToString("0.00000"));
          
      }


      public static void Palindrome()
      {
          string s = "abca".ToLower();
          char[] f = s.ToCharArray();
          string h = "";
          string c = "";
          for (int i = f.Length - 1, j = 0; i >= f.Length / 2 && j <= i; i--, j++)
          {
              if (f[i]==f[j])
              {
                  c += f[i] + f[j];
              } 
              if (f[i]!=f[j])
              {
                  h += f[j];
              }
          }
          if (c.Length != 0 && (h.Length==2 ||h.Length==1 ||h.Length==0))
          {
              Console.WriteLine("True");
          }
          else
          {
              Console.WriteLine("False");
          }
          

      }
    }
}
