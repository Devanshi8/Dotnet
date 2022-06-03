using System;
using System.Collections;
//Collection -> Non Generic -> ArrayList
namespace ConsoleApp20
{
    class Program
    {
        static void Main2(string[] args)
        {
            ArrayList al = new ArrayList();
            string str = "devanshi";
            int x = 7;
            DateTime d = DateTime.Now;
            al.Add(str);
            al.Add(x);
            al.Add(d);
            al.Add("hello");
            
            foreach(var item in al)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
