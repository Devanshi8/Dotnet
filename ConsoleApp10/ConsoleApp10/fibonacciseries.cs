using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class fibonacciseries
    {
        //Fibonacci series 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements : ");
            int n = Convert.ToInt32(Console.ReadLine()); //5
            Console.WriteLine("Fibonacci Series : ");
            fibseries(n);
        }
        static void fibseries(int n)
        {
            int n1 = 0;
            int n2 = 1;
            Console.Write(n1+"  "+n2+"  "); //0 //1
            int n3;
            while(n>0)//5>0 4>0 3>0 2>0 1>0 0>0(false condn)
            {
                n3 = n1 + n2;//0+1=1 1+1=2 1+2=3 2+3=5 3+5=8
                Console.Write(n3+"  ");//1 //2 //3 //5 //8
                n1 = n2;//n1=1 n1=1 n1=2 n1=3 n1=5
                n2 = n3;//n2=1 n2=2 n2=3 n2=5 n2=8
                n--;//n=4 n=3 n=2 n=1 n=0
                
            }

        }
    }
}
