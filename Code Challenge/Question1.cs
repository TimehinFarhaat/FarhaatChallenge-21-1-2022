using System;


namespace Code_Challenge
{
    class Question1
    { 
         static void Duplicate()
        {
            Console.Write("Enter the length of the array: ");
            int lent = int.Parse(Console.ReadLine());
            int[] arr=new int[lent];
            for (int i = 0; i < lent; i++)
            {
                Console.Write($"input at index {arr[i]}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            string n = "";
            int cont = 0;
            for (int i = 0; i < lent; i++)
            {
                n += arr[i];
                if (arr[i]==0)
                {
                    cont++;
                    n += arr[i]+" ,";
                }
            }

            string b = n.Substring(0, n.Length - cont);
            Console.WriteLine(b);



        }


         static void Main2()
         {
           // Duplicate();
              // Range();
           // Stone();
           // Palindrome();
          //Name();
         }


         static void Range()
         {
             Console.Write("Enter the length of array: ");
             int lent = int.Parse(Console.ReadLine());
             int[] num = new int[lent];
             for (int i = 0; i < lent; i++)
             {
                 Console.Write($"Enter the number at index {num[i]}: ");
                 num[i] = int.Parse(Console.ReadLine());
             }

             for (int i = 0; i < lent - 1; i++)
             {
                 for (int j = 0; j < lent - 1; j++)
                 {
                     if (num[j] > num[j + 1])
                     {
                         int temp = num[j];
                         num[j] = num[j + 1];
                         num[j          + 1] = temp;
                     }
                 }
             }

             for (int i = 0; i < num.Length; i++)
             {
                 if (num[i + 1] - num[i] != 1)
                 {
                     int hold = num[i + 1] + 1;
                     Console.WriteLine(hold);
                 }
             }

             if (num.Length - num[num.Length - 1] == 1)
             {
                 Console.WriteLine(num[num.Length-1]+1);
             }
                 
         }
         


         static void Stone()
         {
            Console.Write("Enter the length of array: ");
            int lent = int.Parse(Console.ReadLine());
            int[] num=new int[lent];
            for (int i = 0; i < lent; i++)
            {
                Console.Write($"Enter the number at index {num[i]}: ");
                num[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < lent - 1; i++)
            {
                 for (int j = 0; j < 1; j++)
                 {
                     if (num[j] > num[j + 1])
                     {
                         int temp = num[j];
                         num[j] = num[j + 1];
                         num[j+1] = temp;
                     }
                 }
            }
            string newalpha = "";
                 
                for (int i = 0; i < num.Length-1 ; i++)
                {
                    int newnum = num[i + 1];

                    if (num[i]>num[i+1])
                    {
                        newnum = num[i] - num[i + 1];
                        newalpha= (num[i+1]).ToString();
                    }
                }
                Console.WriteLine(newalpha);

            
             if(num.Length==1)
             {
                 Console.WriteLine(num[0]);
             }
         }


         static void Palindrome()
         {

             Console.Write("Enter the words: ");
             string words = Console.ReadLine();
             var c = words.ToCharArray();
             for (int i = 0; i < words.Length - 1; i++)
             {
                 for (int j = 0; j < 1; j++)
                 {
                     if (c[j] > c[j + 1])
                     {
                         char temp = c[j];
                         c[j] = c[j + 1];
                         c[j          + 1] = temp;
                     }
                 }
             }
             int con = 1;
             int cont = 1;
             int a = 0;
             int d = 0;

             if (words.Length==1)
             {
                 Console.WriteLine(cont);
             }
             else
             {

                 for (int i = 1; i < words.Length; i++)
                 {
                     if (c[i] == c[i - 1])
                     {
                         cont++;
                         break;
                     }
                     else
                     {
                         con = 1;
                         break;
                     }
                     
                 }
                 Console.WriteLine(a);
             }
             

         }


         static void Name()
         {
             Console.Write("Enter your name: ");
             string name = Console.ReadLine();
             for (int i = name.Length-1; i >= 0; i--)
             {
                 Console.Write(name[i]);
             }

         }
    }
}
