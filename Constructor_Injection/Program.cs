using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Injection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();
        }
    }

    interface Ilogger 
    {
        void Log();
    }

    class DatabaseLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : Ilogger
    {
        public void Log()
        {
            Console.WriteLine("Filed to database");
        }
    }

    class EmployeeManager
    {
        private Ilogger _logger;
        public EmployeeManager(Ilogger logger)
        {
            _logger = logger;
        }
        public void Add() 
        {
            _logger.Log();
        Console.WriteLine("Added");
        }
    }
}
