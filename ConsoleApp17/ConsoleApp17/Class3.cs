using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;

using System.Threading.Tasks;
namespace ConsoleApp3
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }


    class PersonImplementation
    {
        public void GetName(IList<Person> persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine($"{person.Name} - {person.Address}");
            }
        }


        public void Average(List<Person> persons)
        {
            Console.WriteLine($"Average age of persons: {persons.Average(p => p.Age)}");
        }


        public void Max(IList<Person> persons)
        {
            Console.WriteLine($"Average age of persons: {persons.Max(p => p.Age)}");
        }
    }
    class Test
    {
        static void Main()
        {

        }
    }
}