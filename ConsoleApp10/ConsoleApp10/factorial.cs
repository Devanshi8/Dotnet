using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class factorial
    {
        static void Main2(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());//5
            int ans= factnum(n);//ans=5
            Console.WriteLine("Factorial of " + n + " is: "+ ans);//120
        }
        static int factnum(int n)
        {
            int i=1;
            while(n>1) //5>1 4>1 3>1 2>1 1>1
            {
                i=i*n;   // i=1*5=5  5*4=20  20*3=60  60*2=120
                
                n--;    //n=4 n=3 n=2 n=1
                
            }
            return i;  //i=120
        }
    }
}
