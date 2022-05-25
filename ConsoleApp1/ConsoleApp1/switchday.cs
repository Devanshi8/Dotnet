using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class switchday
    {
        static void main4(string[] args)
        {
            //Print days Mon-Sun using swtich-case, default=> print invalid
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
            }
        }
    }
}
