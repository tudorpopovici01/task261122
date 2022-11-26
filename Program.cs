using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.showJsonFormat("Popovici", "IS41R", 8.5);
            Console.ReadKey();
        }
    }
}
