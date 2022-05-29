using System;

namespace ConsoleApp14
{
    //Create a new C # project with three classes plus another class to test the logic in your code. The main classes of the program are the following classes:

    //    Person
    //    Student
    //    Teacher
    //The Student and Teacher classes inherit from the Person class.
    public class Person
    {
        //The Person class must have two public methods Greet() and SetAge(int age) that will assign the age of the person.
        protected int x;

        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
        public void SetAge(int age)
        {
            x = age;
        }

    }

    public class Student : Person
    {
        //The Student class will include a public Study() method that will write I'm studying on the screen.
        //Also create a public method ShowAge() in the Student class that writes My age is: x years old on the screen.
        public void Study()
        {
            Console.WriteLine("I'm studying ");
        }
        public void ShowAge()
        {
            Console.WriteLine("My age is: " + x);
        }
    }

    public class Teacher : Person
    {
        //The Teacher class will include a public Explain() method that will write I'm explaining on the screen.

        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }

    }
    class StudentProfessorTest
    {
        static void Main(string[] args)
        {
            //Create a new Person and make him say hello
            Person pr = new Person();
            pr.Greet();

            //Create a new Student, set an age, say hello, and display her age on the screen.
            Student st = new Student();
            st.SetAge(15);
            st.Greet();
            st.ShowAge();

            //Create a new Teacher, set an age, say hello and start the explanation.
            Teacher t = new Teacher();
            t.SetAge(35);
            t.Greet();
            t.Explain();

        }
    }
}

//Output:
//Create a new Person and make him say hello:
//Hello!
//Hello!
//My age is: 15
//Hello!
//I'm explaining






/*Problem Statement:
 *
      
Create a new C # project with three classes plus another class to test the logic in your code. The main classes of the program are the following classes:

Person
Student
Teacher

The Student and Teacher classes inherit from the Person class.

The Student class will include a public Study() method that will write I'm studying on the screen.

The Person class must have two public methods Greet() and SetAge(int age) that will assign the age of the person.

The Teacher class will include a public Explain() method that will write I'm explaining on the screen.

Also create a public method ShowAge() in the Student class that writes My age is: x years old on the screen.

You must create another test class called StudentProfessorTest with a Main method to do the following:

Create a new Person and make him say hello
Create a new Student, set an age, say hello, and display her age on the screen.
Create a new Teacher, set an age, say hello and start the explanation.
 
*/

