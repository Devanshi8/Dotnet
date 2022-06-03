using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
    class Class2
    {
        //Generic Collections
        //SortedList<keytype,valuetype> -> it is a class that has the combination of arraylist and hashtable
        public static void Main2()
        {
           
            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.Net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (KeyValuePair<string, string> item in sl)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }
        }
    }
}
