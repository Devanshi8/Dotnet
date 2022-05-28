using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class fibonacciseries
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci Series : ");
            fibseries(n);
        }
        static void fibseries(int n)
        {
            int n1 = 0;
            int n2 = 1;
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            int n3;
            while(n>0)
            {
                n3 = n1 + n2;
                Console.Write(n3+"  ");
                n1 = n2;
                n2 = n3;
                n--;
                
            }

        }
    }
}
