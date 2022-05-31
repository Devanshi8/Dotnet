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
            int len = name.Length;

            for (i = 0; i < len; i++)
            {
                for (j = len; j >=0; j--)
                {
                    str[i] = name[j];
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
