using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    public class Shape // Base Class
    {
        protected double length;
        protected double width;
    }

    public class Square:Shape // Inherit the Shape Class
    {
        public Square(double side) //side=4.0
        {
            length=width=side;//length = width = 4.0  --> length =4.0 width=4.0
        }
        public void printArea()
        {
            Console.WriteLine("Area of a Square : " + (length * width));//4.0*4.0 = 16
        }
    }

    public class Rectangle : Shape // Inherit the Shape Class
    {
        public Rectangle(double l, double w) // l=5.0 w=2.3
        {
            length = l; // length=5.0
            width = w; // width = 2.3
        }
        public void printArea()
        {
            Console.WriteLine("Area of a Rectangle : " + (length * width)); //5.0*2.3 = 11.5
        }
    }
    class Class2
    {
        public static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5.0,2.3); //l=5.0 w=2.3
            rect.printArea();//Area of a Rectangel : 11.5

            Square sq = new Square(4.0);//side = 4.0
            sq.printArea();//Area of a Square : 16
        }
    }
}
