using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program to multiply 2 matrix
            
                int[,] a = new int[2, 2];
                int[,] b = new int[2, 2];
                int[,] mul = new int[2, 2];
                int i, j, k;
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
                        mul[i, j] = 0;
                        for (k = 0; k < 2; k++)
                        {
                            mul[i, j] += a[i, k] * b[k, j];
                        }
                    }
                }
                Console.WriteLine("Matrix Multiplication : ");
                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 2; j++)
                    {
                        Console.Write(mul[i, j] + " ");
                    }
                    Console.WriteLine();
                }

            
        }
    }
}
