using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class Program4
    {
        static void Main(string[] args)
        {
           /* var x = 5;
            x = "string";
            Console.WriteLine(x);*/

          /*  var y = "computer";
            y = 2;
            Console.WriteLine(y);*/

            dynamic d = "Hello!";
            d = 2022;
            d = "World!";
            Console.WriteLine(d);

            var i;
            for(i=5;i<7;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
