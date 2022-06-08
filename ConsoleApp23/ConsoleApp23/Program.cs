using ConsoleApp23.Models;
using System.Linq;
using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Scaffold-DbContext "Data Source=DESKTOP-8T2OLIG;Initial Catalog=SampleDB;Integrated Security=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

            //Insert the values
            //Console.WriteLine("Enter Your Name : ");
            //string name = Console.ReadLine();
            SampleDBContext db = new SampleDBContext();
            //Tblsample tblsample = new Tblsample();
            //tblsample.Text = name;
            //db.Tblsamples.Add(tblsample);
            //db.SaveChanges();

            //Display the inserted Values
            var data = db.Tblsamples;
            //Console.WriteLine("Values from database ");
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Id + " | " + item.Text);
            //}

            ////Delete the Value
            //Console.WriteLine("Enter ID of your Name which you want to Delete : ");
            //int DeleteItem = Convert.ToInt32(Console.ReadLine());
            //var DeleteObject = db.Tblsamples.Where(x => x.Id == DeleteItem).FirstOrDefault();//if item match oe empty
            //db.Tblsamples.Remove(DeleteObject);
            //db.SaveChanges();

            ////Display Values after deletion

            //Console.WriteLine("Values from database ");
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Id + " | " + item.Text);
            //}


            //Updating the values
            
            Console.WriteLine("Enter ID where you want to update your values : ");
            int InserttItem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the new Name : ");
            var newName = Console.ReadLine();
            var UpdattedObject = db.Tblsamples.Where(x => x.Id == InserttItem).FirstOrDefault();
            UpdattedObject.Text = newName;
            db.Tblsamples.Update(UpdattedObject);
            db.SaveChanges();

            //Display Values after Updation
            Console.WriteLine("Value After Updation : ");
            foreach(var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.Text);
            }
        }
    }
}
