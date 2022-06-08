using System;
using System.Collections;
using System.Text;

namespace ConsoleApp5
{
    class Prog
    {
        
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(10);
            al.Add(20);
            al.Add(-5); 
            al.Add(30);
            al.Add(6);
            Console.WriteLine($"Capacity is : { al.Capacity}");
                al.Remove(6);
            Console.WriteLine($"Capacity is : { al.Capacity}");
        }
    }
    
}
