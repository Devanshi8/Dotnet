using System;
using System.Collections.Generic;
namespace ConsoleApp21
{
    // Generic collections means we include the datatype as well
    //List ->its similar to the ArrayList
    class Program
    {
        static void Main2(string[] args)
        {
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(101);
            lst.Add(102);
            lst.Add(103);
            lst.Add(104);

            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }
    }
}
