using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    class Person
    {
        protected string Name;
        public Person(string name)
        {
            Name = name;
        }
        public string ToString()
        {
            Console.WriteLine(Name);
            return Name;
        }
        ~Person()
        {
            
        }
    }
    class Class1
    {
        public static void Main()
        {
            Person[] per = new Person[3];
            
            for(int i=0;i<per.Length;i++)
            {
                Person p = new Person(Console.ReadLine());
                    
            }
            for(int i = 0; i < per.Length; i++)
            {
                per[i].ToString();
            }
        }
    }
}
/*Practice Problem 2
Create a C# program that prompts the user for three names of people and stores them in an array of Person-type objects. 
To do this, first create a Person class that has a Name property of type string, a constructor that receives the name as a parameter,
a destructor that assigns the name to empty and overwrites the ToString () method.

End the program by reading the people and executing the ToString () method on screen.
*/