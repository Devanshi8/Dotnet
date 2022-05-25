using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Calcswitch
    {
        static void main5(string[] args)
        {
            /*
             
             Create a calculator
             where you will ask user what he want to do
             1.Add
             2.Sub
             3.Division
             4.Multiplication

             1 
             Please enter 2 values
             4,5
             Sum of two number is 9
             5
             default:Enter a valid choice      
             */
             
            Console.WriteLine("Enter Your Choice :");
            int choice= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter two Values : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            switch (choice)
            {
                case 1:
                    c = a + b;
                    Console.WriteLine("Sum = "+c);
                    break;
                case 2:
                    c = a - b;
                    Console.WriteLine("Sub = "+c);
                    break;
                case 3:
                    c = a * b;
                    Console.WriteLine("Mul = "+c );
                    break;
                case 4:
                    c = a / b;
                    Console.WriteLine("Div = "+c);
                    break;
                default:
                    Console.WriteLine("Enter a valid choice");
                    break;
            }
        }
    }
}
