using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Pattern1
    {
        static void main6(string[] args)
        {
            /* 
             To print
            *
            **
            ***
            ****
            *****
              */
            
            for (int i = 1; i <= 5; i++)
             {
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write("* ");
                 }
                 Console.WriteLine();
             }
            
        }
    }
}
