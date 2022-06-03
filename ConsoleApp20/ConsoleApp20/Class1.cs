using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace ConsoleApp20
{
                                 //HashTable Key->values
    class Class1
    {
        public static void Main2()
        {
            Hashtable ht = new Hashtable();
            ht.Add("a", "abc");
            ht.Add("b", "vb.net");
            ht.Add("c", "csharp.net");
            ht.Add("d", "asp.net");
            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+" ==> "+item.Value);
            }
           
        }
    }
}
