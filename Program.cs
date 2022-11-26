using System;

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
