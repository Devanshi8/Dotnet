using System;

namespace ConsoleApp4
{
    class Program
    {
        /*
         Check weather a string is palindrome or not

            mam=>mam
            dad=>dad
            madam=>madam
         */
        static void Main()
        {
            int i, j;
            string name = Console.ReadLine();
            string str=name;
            Boolean flag = false;
            int len = str.Length;

           
                for (j = len-1; j >=0; j--)
                {
                    Console.WriteLine(str[j]);
                }
            for (i = 0; i < len; i++)
            {
                for (j = str.Length-1; j >= 0; j--)
                {
                    if (name[i] == str[j])
                    {

                    }
                }
                if (flag == true)
                {
                    Console.WriteLine("String is Palindrome");
                }
                else
                {
                    Console.WriteLine("String is not Palindrome");
                }

            }


            /*       for (i=0;i<len;i++)
                   {
                       for (j =name.Length; j > 0; j--)
                       {
                           if(name[i]==name[j])
                           {
                               Console.WriteLine(name[i]);
                               Console.WriteLine(name[j]);
                               flag = true;
                           }
                       }
                   } 
             for (i = 0; i < len; i++)
            {
                if (str[i] == name[i])
                {
                    flag = true;
                    Console.Write(str[i]);
                    Console.Write(name[i]);
                }
            }

             if (flag == true)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is not Palindrome");
            }

               */
        }
    }
}
