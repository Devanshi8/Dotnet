using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp19
{
    public class Location
    {
        private double x;
        private double y;
    }
    public class Shape
    {
        protected Location c;
        
        public string ToString()
        {
            return string.Empty; 
        }
        public double Area()
        {
            return 0.00;
        }
        public double Perimeter()
        {
            return 0.00;
        }
    }
    public class Rectangle : Shape
    {
        protected double side1;
        protected double side2;
    }
    public class Circle:Shape
    {
        protected double radius;
    }
    public class class2
    {
        public static void Main()
        {

        }
    }
}
