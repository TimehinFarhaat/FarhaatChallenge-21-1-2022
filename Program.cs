using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;


namespace Code
{
    class Program
    {
        public static void Main()
        {
            Question2();
            Question1();
        }


        public static void Question2()
        {
            int[] a = new[] { 1, 3, 2, 2, 5, 2, 3, 7 };
            HashSet<int> b = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[i] > a[j])
                    {
                        if (a[i] - a[j] == 1)
                        {
                            b.Add(a[i]);
                            b.Add(a[j]);

                        }
                    }
                    else
                    {
                        if (a[j] - a[i] == 1)
                        {
                            b.Add(a[i]);
                            b.Add(a[j]);
                        }
                    }
                }
            }

            Hashtable t = new Hashtable();
            foreach (var c in b)
            {
                t.Add(c, 0);
            }

            foreach (var r in a)
            {
                if (t.ContainsKey(r))
                {
                    t[r] = (int) t[r] + 1;
                }
            }

            List<int> list = new List<int>();
            List<int> list1 = new List<int>();
            foreach (DictionaryEntry entry in t)
            {
                list.Add((int) entry.Key);
                list1.Add((int) entry.Value);
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j           + 1] = temp;

                        int tem = list1[j];
                        list1[j] = list1[j + 1];
                        list1[j            + 1] = tem;


                    }
                }
            }

            int w = 0;
            int y = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i + 1] - list[i] == 1)
                {
                    w = list1[i] + list1[i + 1];
                    if (y < w)
                    {
                        y = w;
                    }

                }
            }

            Console.WriteLine(y);


        }


        public static void Question1()
        {
            int a = 5;
            int v = 1;
            for (int i = 1; i <= a; i++)
            {
                a -= v;
                v++;
            }
            Console.WriteLine(v-1);


        }
    }





}
     
