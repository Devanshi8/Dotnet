using System;

namespace ConsoleApp22
{
        // Exception Handling
    class Program
    {
        static void Main(string[] args)
        {
            try//harmful code
            {
                int a = 5, b = 0;
                int c = a / b;

            }
            catch(Exception ex)
            {
                Console.WriteLine("Division By Zero Error");
            }
        }
    }
}
