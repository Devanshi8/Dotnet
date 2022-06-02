using System;

namespace ConsoleApp18
{
    class extra
    {
        private string name;
        public string Nm
        {
            set
            {
                name=Nm;
            }
            get
            {
                return name;

            }
        }
        public extra()
        {
            name = Nm;
        }
        public string m1(string s)
        {
            name = s;
            Console.WriteLine(name);
            return name;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            extra ex = new extra();
            ex.m1("Hello");
        }
    }
}
