using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    class A //Base Class
    {
        protected int a=5;
    }
    class B:A//Dericed Class
    {
        public void iprint()
        {
            Console.WriteLine(a);
        }
    }
    
    class Class1
    {
        public static void Main2(string[] args)
        {
            B b = new B();
           
            b.iprint();
        }
    }
}
