using System;

namespace ConsoleApp9
{
    class Program
    {
        //Write a program in C# Sharp to print all unique elements in an array.
        static void Main(string[] args)
        {
            int i, j,k;
           
            Console.WriteLine("Enter the total element number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] a = new int[n];
            int count;
            Console.WriteLine("Enter the values:");
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Unique Elements : \n");
            for (i = 0; i < n; i++)
            {
                count = 0;
                for (j = 0; j < i-1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                for (k = i + 1; k < n; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        count++;
                    }
                    if (arr[i] == arr[i + 1])
                    {
                        i++;
                    }
                }
                if(count==0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
