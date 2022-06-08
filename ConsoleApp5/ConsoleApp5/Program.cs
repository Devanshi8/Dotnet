using System;

namespace ConsoleApp5
{
    class Program
    {
        //Find second highest number from an array
        static void Main2(string[] args)
        {
            
            int temp = 0;
            int i,j;
            Console.WriteLine("Enter the total element number: ");
            int n= Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the values:");
            for (i = 0; i < n; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
           
            for (i = 0; i < n; i++)
            {
                for(j=i+1;j<n;j++)
                {
                    if(arr[i]<arr[j])
                    {
                        temp = arr[i];
                        arr[i]=arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.Write("Maximum Arraylist : ");
            for (i = 0;i<n;i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\nSecond Largest Number => "+arr[1]);

        }
    }
}
