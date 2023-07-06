using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Database database = new Oracle();
            database.Add();
            database.Delete();
            Database database2 = new SqlServer();
            database2.Delete();
            database2.Add();

        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete();
    }

    class SqlServer : Database
    {
          public override void Delete()
        {
            Console.WriteLine("Deleted by sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
