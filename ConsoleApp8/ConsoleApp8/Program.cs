using System;

namespace ConsoleApp8
{
    class Program
    {
        //transpose of matrix
        static void Main(string[] args)
        {
            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
           
            int i, j;
            Console.WriteLine("Enter the Values of a[2][2]");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("a["+i+"],["+j+"]:");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Before Transpose :");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Transpose of Matrix :");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    b[j, i] = a[i,j];
                }
            }

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(b[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
