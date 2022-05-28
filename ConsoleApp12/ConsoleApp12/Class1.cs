using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp12
{
    class SampleClass
    {
        private int a;
        private int b;
        public SampleClass() { }//Default Constructor
        public SampleClass(SampleClass obj) //Copy Constructor
        {
            a = obj.a;
            b = obj.b;
        }
        public void setdata(int x,int y) 
        {
            a = x;
            b = y;
        }
        public void printData()
        {
            Console.WriteLine(a + " , " + b);
        }
       
    }
    class run
    {
        static void Main(string[] args)
        {
            SampleClass obj1 = new SampleClass();
            obj1.setdata(5, 6);
            obj1.printData();
            SampleClass obj2 = new SampleClass(obj1);
            obj2.printData();
        }
    }
}
