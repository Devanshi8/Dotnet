﻿using System;

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
            int len = name.Length;  
            
               
                for(i=0;i<len;i++)
                {
                    for (j = name[len-1]; j > 0; j--)
                    {
                        if(name[i]==name[j])
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
