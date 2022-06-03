using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace ConsoleApp20
{
                    //Stack => LIFO
    class Class3
    {
        public static void Main2()
        {
            Stack stk = new Stack();
            stk.Push("cs.net");
            stk.Push("vb.net");
            stk.Push("asp.net");
            stk.Push("sql server");
            

            foreach (var item in stk)
            {
                Console.WriteLine(item);
            }
        }
    }
}
