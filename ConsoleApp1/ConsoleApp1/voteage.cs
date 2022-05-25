using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class voteage
    {
        static void main3(string[] args)
        {
            //Person is able to vote or not & age>60 is senior citizen
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
            }
             */
        }
    }
}
