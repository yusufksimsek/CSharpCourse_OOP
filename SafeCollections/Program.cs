using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, firstName = "Engin" });
            //customers.Add(new Customer { Id = 2, firstName = "Demir" });

            List<Customer> customers = new List<Customer>       // üstteki stilin yanısıra bu şekilde de yazılabilir 
            {
                new Customer { Id = 1, firstName = "Yusuf" },
                new Customer { Id = 2, firstName = "Kerem" }
            };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.firstName);
            }

        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string firstName { get; set; }
    }

}
