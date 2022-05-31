using System;

namespace ConsoleApp16
{
    class BaseClass
    {
        public virtual void show()
        {
            Console.WriteLine("This is BaseClass..");
        }
    }
    class DerivedClass:BaseClass
    {
        public override void show()
        {
            Console.WriteLine("This is Derived Class..");
        }
    }
    class Program
    {
        static void Main()
        {
            DerivedClass dc = new DerivedClass();
            dc.show();//DerivedClass method

            BaseClass bc;
            bc= new BaseClass();
            bc.show();//BaseClass method

            bc = new DerivedClass();
            bc.show();//before virtual and override  - BaseClass method 
                      //after adding virtual and override its - DerivedClass method
            
        }
    }
}
//Output
/*

without using virtual and override
This is Derived Class..
This is BaseClass..
This is BaseClass..

After adding virtual and override
This is Derived Class..
This is BaseClass..
This is Derived Class..

*/