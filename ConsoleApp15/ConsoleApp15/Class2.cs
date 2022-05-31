using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace ConsoleApp15
    {
        //Operator Overloading Multiplication
        class Calculator
        {
            public int num1, num2;
            public Calculator(int n1, int n2)
            {
                num1 = n1;//5   7
                num2 = n2;//2   3
            }
            public void Print()
            {
                Console.WriteLine("Number1 = " + num1);//35
                Console.WriteLine("Number2 = " + num2);//6
            }
            public static Calculator operator *(Calculator c1, Calculator c2)//     (5,2)                 (7,3)
            {                                                               //(c1.num1,c1.num2)     (c2.num1,c2.num2)
                Calculator c3 = new Calculator(0, 0);
                c3.num1 = c1.num1 * c2.num1;//c3.num1 = (c1.num1 = 5) * (c2.num1 = 7) = 35 
                c3.num2 = c1.num2 * c2.num2;//c3.num2 = (c1.num2 = 2) * (c2.num2 = 3) = 6
                return c3;// c3=(num1,num2) = (35,6)
            }
        }
        class Class2
        {
            public static void Main2()
            {
                Calculator calc1 = new Calculator(5, 2);
                Calculator calc2 = new Calculator(7, 3);
                Calculator calc3 = new Calculator(0, 0);
                calc3 = calc1 * calc2;//operator overload
                calc3.Print();
            }
        }
    }

}
//Output:
/*
 
Number1 = 35 <5*7>
Number2 = 6  <2*3>

*/