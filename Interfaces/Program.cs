using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            
            //manager.Add(new Customer { Id = 1, FirstName = "Yusuf", LastName = "Simsek", Address="İstanbul"});  // new customerda yeni nesne oluşturduk 
            
            Student student = new Student
            {
                Id = 1,
                FirstName = "Kerem",
                LastName = "Simsek",
                Department = "Computer Sciences",
            };
            //manager.Add(student);

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new sqlServerCustomerDal());
        }
    }

    

    interface IPerson   // soyut nesne 
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson      // IPerson özelliklerini kullanır 
    {
        public int Id { get; set; }         // iki türlü de yazılabilir 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson       // IPerson özelliklerini kullanır 
    {

        public int Id { get; set; }         // iki türlü de yazılabilir 
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }

    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName + " "+ person.LastName);
        }
    }

}
