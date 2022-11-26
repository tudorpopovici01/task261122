using System;

namespace StudentProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.showJsonFormat("Popovici", "IS41R", 8.5);
            student = new Student("Popovici Tudor", "IS41R", 8.5);
            Masterand masterand = new Masterand("Lisii Vasile", "IS11M", 7);
            control(student, masterand);
            student.averageMark = student.averageMark * 0.85;//micsoram cu 15%
            masterand.averageMark = masterand.averageMark * 0.95;//micsoram cu 5%
            control(student, masterand);
            Console.ReadKey();
        }

        private static void control(Student student, Masterand masterand)
        {
            if (student.averageMark < masterand.averageMark)
            {
                Console.WriteLine(String.Format("Nota medie a lui {0} este {1}, nota medie a lui {2} este {3}, diferenta = {4} în favoarea {2}", student.Nume, student.averageMark, masterand.Nume, masterand.averageMark, masterand.averageMark - student.averageMark));
            }
            else
            {
                Console.WriteLine(String.Format("Nota medie a lui {0} este {1}, nota medie a lui {2} este {3}, diferenta = {4} în favoarea {0}", student.Nume, student.averageMark, masterand.Nume, masterand.averageMark, student.averageMark - masterand.averageMark));
            }
        }
    }
}
