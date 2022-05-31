using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class Calculator
    {
        public int num1, num2;
        public Calculator(int n1,int n2)
        {
            num1 = n1;// 5  7
            num2 = n2;// 9  8
        }
        public void Print()
        {
            Console.WriteLine("Number1 = " + num1);//12
            Console.WriteLine("Number2 = " + num2);//17
        }
        public static Calculator operator +(Calculator c1, Calculator c2)//     (5,9)                 (7,8)
        {                                                               //(c1.num1,c1.num2)     (c2.num1,c2.num2)
            Calculator c3 = new Calculator(0, 0);
            c3.num1 = c1.num1 + c2.num1;//c3.num1 = (c1.num1 = 5) + (c2.num1 = 7) = 12
            c3.num2 = c1.num2 + c2.num2;//c3.num2 = (c1.num2 = 9) + (c2.num2 = 8) = 17
            return c3;// c3=(num1,num2) = (12,17)
        }
    }
    class Class1
    {
        public static void Main()
        {
            Calculator calc1 = new Calculator(5,9);
            Calculator calc2 = new Calculator(7,8);
            Calculator calc3 = new Calculator(0,0);
            calc3 = calc1 + calc2;//operator overload
            calc3.Print();

        }
    }
}
//Output:
/*
 
Number1 = 12 <5+7>
Number2 = 17  <9+8>

*/