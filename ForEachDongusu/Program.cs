using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new String[3] { "Engin", "Derin", "Salih" };

            foreach (var s in students)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();

        }
    }
}
