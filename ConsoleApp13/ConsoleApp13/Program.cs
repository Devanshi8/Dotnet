using System;

namespace ConsoleApp13
{
    class privateExample
    {
       
        public privateExample(double r)
        {
            _radius = r;
        }
        private double _radius;
        private const double _pi = 3.14;
      
        public double radius
        {
            get
            {
                return _radius;
            }
        }
        public void printCircumference()
        {
            Console.WriteLine(2 * _pi * radius);
        }

    }
    class Program
    {
        static void Main2(string[] args)
        {
            privateExample pex = new privateExample(2.5);
            Console.WriteLine("Radius : "+pex.radius);
            pex.printCircumference();
            
        }
    }
}
