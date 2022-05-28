using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class Program3
    {
        static void Main2(string[] args)
        {
            int a = 25;
            int result = m1(a);//only able to get one value from the function
            Console.WriteLine("m1 method return " + result);

            int x = 5,ans;
            m2(x, out ans);
            Console.WriteLine("m2 OUT method return " + ans); //ans = 26

            int i, j, k;
            m3(out i, out j, out k);//can receive multiple values from function
            Console.WriteLine("m3 OUT method return " + i+" "+ j+" "+k);// 5 10 15
        }

        static int m1(int a) //a=25
        {
            return a * 5; // 25*5 = 125
        }
        
        static void m2(int x, out int ans) // x=5
        {
            ans = x * x + 1; // ans = 5 * 5 + 1 = 26  ans=26
        }
       
        static void m3(out int i, out int j,out int k)//return multiple values using out
        {
            i = 5; 
            j = 5+i; // j=5+5=10
            k = i+j; // k=5+10=15
        }

        
    }
}
//Output:
//m1 method return 125
//m2 OUT method return 26
//m3 OUT method return 5 10 15
