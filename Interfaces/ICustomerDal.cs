using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class sqlServerCustomerDal : ICustomerDal
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("sql added");
        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("sql deleted");
        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("sql updated");
        }
    }
    class OracleServerDal : ICustomerDal
    {
        void ICustomerDal.Add()
        {
            Console.WriteLine("oracle added");
        }

        void ICustomerDal.Delete()
        {
            Console.WriteLine("oracle deleted");
        }

        void ICustomerDal.Update()
        {
            Console.WriteLine("oracle updated");
        }
    }

    class CustomerManager
    {
        public void 
            Add(ICustomerDal customerdal)
        {
            customerdal.Add();
        }
    }

}
