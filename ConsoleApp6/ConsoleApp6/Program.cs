using System;

namespace ConsoleApp6
{
    class Program
    {
       // Write a program in C# Sharp to count a total number of duplicate elements in an array.
        static void Main(string[] args)
        {
           
            int i, j;
            Console.WriteLine("Enter the total element number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter the values:");
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.Write(arr[i]+" ");
                    }
                }
            }
            
        }
    }
}
