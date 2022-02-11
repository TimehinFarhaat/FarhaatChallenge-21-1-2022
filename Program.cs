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
           // Question2();
            Question1();
        }


        public static void Question2()
        {
            bool check = true;
            var e = "ab";
            var s1 = e.ToCharArray();
            var h=new List<string>();
            string s2 = "eidboaoo";
            string a = "";
            for (int i = 0; i < s1.Length; i++)
            {
                for (int j = 0; j < s1.Length; j++)
                {
                    var b = s1[ i];
                    s1[i] = s1[j];
                    s1[j] = b;
                    a = new string(s1);
                    if (!h.Contains(a))
                    {
                        h.Add(a);
                    }

                    s1 = a.ToCharArray();
                }
                s1 = e.ToCharArray();

                for (int j = s1.Length-1; j >=0; j--)
                {
                    var b = s1[ i];
                    s1[i] = s1[j];
                    s1[j] = b;
                    a = new string(s1);
                    if (!h.Contains(a))
                    {
                        h.Add(a);
                    }

                    s1 = a.ToCharArray();
                }
                s1 = e.ToCharArray();
            }

            foreach (var s in h)
            {
                if (s2.Contains(s))
                {
                    check = true;
                    break;
                }
                else
                {
                    check = false;
                }
            }

            Console.WriteLine(check);

        }


        public static void Question1()
        {
            int n = 3;
            string c = "";
            var d = "";
            var e = "";
                                                     
            var g=new List<string>();
            for (int i = 0; i < n; i++)
            {
                c += "()";
               
            }

            var t = c.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 0; j < t.Length; j++)
                {
                    var b = t[ i];
                    t[i] = t[j];
                    t[j] = b;
                    

                    e=new string(t);
                    if (e[0]!=')' && e[e.Length-1] !='(')
                    {
                        if (!g.Contains(e))
                        {
                            g.Add(e);
                        }
                    }

                    t = e.ToCharArray();
                }
                t = c.ToCharArray();

                for (int j = t.Length-1; j >= 0; j--)
                {
                    var b = t[ i];
                    t[i] = t[j];
                    t[j] = b;
                    d = new string(t);

                    e = new string(d);
                    if (e[0] != ')' && e[e.Length - 1] != '(')
                    {
                        if (!g.Contains(e))
                        {
                            g.Add(e);
                        }
                    }

                    t = e.ToCharArray();
                }

                t = c.ToCharArray();
            }
            foreach (var item in g)
            {
                Console.WriteLine(item);
            }
        }


    }





}
     
