using System;

namespace ConsoleApp12
{
    class Employee
    {
        public string EmpName;
        public int EmpId;
        public string EmpGender;
        private int Salary;

        //<accessmodifier> <classname>(<parameters>)
        public Employee()//Default Constructor
        {
            Salary = 500000;
        }

        //~classname()
        ~Employee() //Destructors
        { }

        public void Getdata()
        {
            Console.WriteLine("Enter Employee Name : ");
            EmpName = Console.ReadLine();

            Console.WriteLine("Enter Employee Id : ");
            EmpId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Gender : ");
            EmpGender = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary : ");
          
        }
        public void Printdata()
        {
            Console.Write("\n\nEmployee Name : " + EmpName);
            Console.Write("\nEmployee Id : " + EmpId);
            Console.Write("\nEmployee Gender : " + EmpGender);
            Console.Write("\nEmployee Salary : " + Salary);
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            /*  Basic Method
             
                Employee e1 = new Employee();

                Console.WriteLine(" Employee Details : \n"); 
           
                e1.Getdata();
                e1.Printdata(); 
            */

            //Using Array Of Objects -> used when we need to store more data

            Console.WriteLine("Number of Employees : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Employee[] emp = new Employee[n];

            for(int i=0;i<n;i++)
            {
                Employee e1 = new Employee();
                e1.Getdata();
                emp[i] = e1;
            }

            Console.WriteLine(" Employee Details : \n");

            for (int i=0;i<n;i++)
            {
                emp[i].Printdata();
            }
          
        }
    }
}
