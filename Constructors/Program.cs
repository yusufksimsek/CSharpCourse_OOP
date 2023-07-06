using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager manager = new CustomerManager(5);
            manager.List();
        }
    }

    class CustomerManager
    {
        private int _count;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public void List() 
        {
            Console.WriteLine("Listed {0} items",_count);
        }

        public void Update()
        {
            Console.WriteLine("Updated");
        }
    }

}
