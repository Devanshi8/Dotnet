using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ConsoleApp23.Models;

namespace ConsoleApp23
{
    class Class1
    {
        static void Main()
        {

            SampleDBContext db = new SampleDBContext();
            Employee empe = new Employee();
            int n = 0;
           
           
            while(n != 5)
            {
                Console.WriteLine("Please Enter what you want to perform: ");
                Console.WriteLine("1. Add Record");
                Console.WriteLine("2. List Record");
                Console.WriteLine("3. Update Record");
                Console.WriteLine("4. Delete Record");
                Console.WriteLine("5. Exit");
                Console.WriteLine("*************************************");

                n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    //Insert the values
                    Console.WriteLine("\nEnter Your Name : ");
                    string name = Console.ReadLine();
                    Tblsample tblsample = new Tblsample();
                    tblsample.Text = name;
                    db.Tblsamples.Add(tblsample);
                    db.SaveChanges();
                    Console.WriteLine("Successfully Inserted..\n\n");
                }
                if (n == 2)
                {
                    //Display the inserted Values
                    var data = db.Tblsamples;
                    Console.WriteLine("\nValues from Table ");
                    foreach (var item in data)
                    {
                        Console.WriteLine(item.Id + " | " + item.Text);
                    }
                    Console.WriteLine("\n\n");
                }
                if (n == 3)
                {
                    //Updating the values

                    Console.WriteLine("\nEnter ID where you want to update your values : ");
                    int InserttItem = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nEnter the new Name : ");
                    var newName = Console.ReadLine();
                    var UpdattedObject = db.Tblsamples.Where(x => x.Id == InserttItem).FirstOrDefault();
                    UpdattedObject.Text = newName;
                    db.Tblsamples.Update(UpdattedObject);
                    db.SaveChanges();
                    Console.WriteLine("Successfully Updated..!!\n\n");
                }
                if (n == 4)
                {
                    //Delete the Value
                    Console.WriteLine("\nEnter ID of your Name which you want to Delete : ");
                    int DeleteItem = Convert.ToInt32(Console.ReadLine());
                    var DeleteObject = db.Tblsamples.Where(x => x.Id == DeleteItem).FirstOrDefault();//if item match oe empty
                    db.Tblsamples.Remove(DeleteObject);
                    db.SaveChanges();
                    Console.WriteLine("Successfully Deleted..!!\n\n");
                }
                if (n > 5) 
                {
                    Console.WriteLine("\nPlease Enter Valid Choice\n");
                }
               
               
            }
        }
    }
}
