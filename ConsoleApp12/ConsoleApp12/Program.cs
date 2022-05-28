using System;

namespace ConsoleApp12
{
    class Employee
    {
        public string EmpName;
        public int EmpId;
        public string EmpGender;
        public int Salary;

        public void Getdata()
        {
            Console.WriteLine("Enter Employee Name : ");
            EmpName = Console.ReadLine();

            Console.WriteLine("Enter Employee Id : ");
            EmpId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Gender : ");
            EmpGender = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary : ");
            Salary = Convert.ToInt32(Console.ReadLine());
        }
        public void Printdata()
        {

            Console.Write("Employee Name : " + EmpName);
            Console.Write("\nEmployee Id : " + EmpId);
            Console.Write("\nEmployee Gender : " + EmpGender);
            Console.Write("\nEmployee Salary : " + Salary);
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();

            Console.WriteLine(" Employee Details : \n"); 
            e1.Getdata();
            e1.Printdata();


          

        }
    }
}
