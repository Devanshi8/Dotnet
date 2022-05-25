using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Pattern2
    {
        static void main8(string[] args)
        {
            /*To print*
             cross in square*/
              
            int n = Convert.ToInt32(Console.ReadLine());//row=9
            
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i==1||j==1||i==n||j==n||i==j||j==n-i+1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}
