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
        static void Main(string[] args)
        {
            int i, j;
            string name = Console.ReadLine();
            
            Boolean flag = false;
              
            
               
                for(i=0;i<name.Length;i++)
                {
                    for (j = name[name.Length]; j > 0; j--)
                    {
                        if(name[i]==name[name.Length])
                        {
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



        }
    }
}
