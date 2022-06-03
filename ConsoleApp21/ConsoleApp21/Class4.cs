using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
                    //  QUEUE<type> -> FIFO   ==> Generic Collections
    class Class4
    {
        public static void Main()
        {
            
            Queue<string> q = new Queue<string>();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sql server");

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(q.Count);
        }
    }
}
