using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class Program2
    {
        //Reference Type    ->    use ref keyword 
        static void Main3(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine("Before Swapping : \n a = " + a + " b =" + b);    //a=5 b=10
            swap(ref a, ref b);//Here we pass the reference of a,b so value changed in the memory location 
            Console.WriteLine("After Swapping : \n a = " + a + " b =" + b);  //a=10 b=5 
        }
        static void swap(ref int x, ref int y)//  x = ref a => x=5    ,     y = ref b => y=10
        {
            int temp;
            temp = x; //temp = 5
            x = y;    //x=10
            y = temp; //y=5
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
// a = 10 b = 5