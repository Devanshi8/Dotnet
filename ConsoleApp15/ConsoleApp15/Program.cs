using System;

namespace ConsoleApp15
{
    //Operator Overloading
    class Program
    {
        public static void sum()
        {
            int ans = 5 + 6;
            Console.WriteLine(ans);

        }
        public static void sum(int a,int b)
        {
            int ans = a + b;
            Console.WriteLine(ans);
        }
        public static void sum(int a, int b,int c)
        {
            int ans = a + b + c;
            Console.WriteLine(ans);
        }
        public static void sum(double a, double b)
        {
            double ans = a + b;
            Console.WriteLine(ans);
        }
        public static void sum(string a, string b)
        {
            int ans = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine(ans);
        }
   
        public static void Main2(string[] args)
        {
            sum(2, 3);
            sum();
            sum(1, 7, 9);
            sum("1", "2");
            sum(5.2, 2.5);
        }
    }
}
