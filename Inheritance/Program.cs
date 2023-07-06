using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer();
            customer.lastName = "Simsek";
            Console.WriteLine(customer.lastName);

        }
    }
    class Person
    {
        public int Id { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }
    }

    class Customer:Person
    { 
        public string city { get; set; }
    }

    class Student : Person
    {
        public string department { get; set; }
    }
}
