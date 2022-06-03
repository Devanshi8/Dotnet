using System;

namespace ConsoleApp22
{
        // Exception Handling
    class Program
    {
        static void Main2(string[] args)
        {
            try//harmful code
            {
                int a = 5, b = 0;
               // int c = a / b;
                int[] arr = new int[2];
                arr[5] = 9;


            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out---Some error occured");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Some error occured");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            finally
            {
                Console.WriteLine("I am coming from finally");
            }
        }
    }
}
