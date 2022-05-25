using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class matrixadd
    {
        static void Main2(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            int[,] ans = new int[2, 2];
            int i, j;
            Console.WriteLine("Enter the Values of a[2][2]");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the Values of b[2][2]");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    ans[i, j] = a[i, j] + b[i, j];
                }
            }
            Console.WriteLine("Matrix Addition : ");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(ans[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}


