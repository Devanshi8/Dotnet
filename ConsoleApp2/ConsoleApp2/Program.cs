using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             To print n number *
            *
            **
            ***
              */
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
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
