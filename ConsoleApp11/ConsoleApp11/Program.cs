using System;

namespace ConsoleApp11
{
    class Program
    {
        //Value Type:
        //we pass the value so after function called the actual parameters value remain same. only changes reflect inside the swap(called) method not in main method 
        static void Main2(string[] args)
        {
            int a=5, b=10;
            Console.WriteLine("Before Swapping : \n a = " + a + " b =" + b);    //a=5 b=10
            swap(a, b); //swap(5,10)
            Console.WriteLine("After Swapping : \n a = " + a + " b =" + b);  //a=5 b=10
        }
        //called method
        static void swap(int x,int y) // x=a y=b    =>     x=5 b=10
        {
            int temp;
            temp=x; //temp = 5
            x= y;   //x=10
            y= temp;   //y=5
            Console.WriteLine("Inside Swap Method : \n a = " + x + " b =" + y); // a=10 b=5
        }
    }
}
//Output:

//Before Swapping :
// a = 5 b = 10
//Inside Swap Method :
// a = 10 b = 5
//After Swapping :
// a = 5 b = 10
