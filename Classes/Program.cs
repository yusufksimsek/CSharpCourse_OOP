using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            customerManager cstm = new customerManager();

            //cstm.update();

            customer customer1 = new customer();
            customer customer2 = new customer();

            customer1.firstName = "Yusuf";
            customer1.lastName = "Simsek";

            customer customer3 = new customer
            {
                Id = 4, city = "İstanbul", firstName = "Kerem", lastName = "Simsek"
            };

            Console.WriteLine(customer3.firstName + " " + customer3.lastName);

        }
    }

  

}
