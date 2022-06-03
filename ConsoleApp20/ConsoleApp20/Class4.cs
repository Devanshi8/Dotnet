using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp20
{
                //Queue -> FIFO Enqueue for adding element
    class Class4
    {
        public static void Main()
        {
            Queue q = new Queue();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sql server");
            q.Dequeue();
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
           
        }
       
}
}
