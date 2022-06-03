using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
            //Stack -> LIFO with type declaration ==> Generic Collections
    class Class3
    {
        public static void Main2()
        {
            Stack<string> stk = new Stack<string>();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sql server");
            stk.Pop();

            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }
        }
    }
}
