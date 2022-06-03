using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{       //Generic Collections
    //Dictionary similar to the Hashtable but we need to specify the data type of key and value both
    class Class1
    {
        public static void Main2()
        {
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "asp.net");
            dct.Add(4, "fs.net");

            foreach (KeyValuePair<int, string> item in dct)
            {
                Console.WriteLine(item.Key + " ==> " + item.Value);
            }
        }
    }
}
