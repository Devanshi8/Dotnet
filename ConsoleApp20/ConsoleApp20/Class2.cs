using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp20
{
                        //SortedList => it is a class has the combination of ArrayList and Hashtable
    class Class2
    {
        public static void Main3()
        {
            SortedList sl = new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.Net");
            sl.Add("cs", "cs.net");
            
            sl.Add("asp", "asp.net");
            foreach (DictionaryEntry item in sl)
            {
                Console.WriteLine(item.Key + " ==> " + item.Value);
            }
           
        }
        
    }
}
