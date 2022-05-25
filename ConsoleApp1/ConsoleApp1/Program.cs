using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int a = 15,b=10;
             string s = "hello";
             String t = "hi";

             Console.WriteLine("Hello World!");
             Console.Write(s+"\n");
             Console.WriteLine(a+b);
             Console.WriteLine(s+t);
             Console.Write(a + "," + b);*/
            //Find Number Is Odd or Even
            /*int n = 23;
            if (n % 2 == 0)
            {
                Console.WriteLine(n + " is Even Number");
            }
            else
            {
                Console.WriteLine(n + " is Odd Number");
            }*/
            /*//Person is able to vote or not & age>60 is senior citizen
            int age = 20;
            if(age < 18)
            {
                Console.WriteLine("Person is not able to Vote");
            }
            else if(age > 60)
            { 
                
                    Console.WriteLine("Person is Senior Citizen");
            }
            else
            { 
                Console.WriteLine("Person is able to Vote");
            }

            /*else
            {
                 Console.WriteLine("Person is able to Vote");
                if(age>60)
                {
                    Console.WriteLine("Person is Senior Citizen");
                }
            }//completed
             */
            /*//Print days Mon-Sun using swtich-case, default=> print invalid
            int ch=5;
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Please Enter Some Valid day ");
                    break;
            }*/


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
            }*/





            /*To print*
             cross in square
              
            int n = Convert.ToInt32(Console.ReadLine());//row=9
            
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i==1||j==1||i==n||j==n||i==j||j==n-i+1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            */


            /* 
             To print
            *
            **
            ***
              
            for (int i = 1; i <= n; i++)
             {
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write("* ");
                 }
                 Console.WriteLine();
             }*/

            int n = Convert.ToInt32(Console.ReadLine());
           
            
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
