using System;

namespace StudentProject
{
    public class Student : Instruit
    {
        private string specialitate;

        public string Specialitate
        {
            get { return this.specialitate; }
            set { this.specialitate = value; }
        }
        public Student() 
        {
            this.Nume = "Popovici Tudor";
            this.grup = "IS41R";
            this.averageMark = 9;
            
        }

        public void showJsonFormat(String nume, String grup, double averageMark)
        {
            Console.WriteLine(
                "{" +
                "nume: " + nume + ", " +
                "grup: " + grup + ", " +
                "averageMark: " + averageMark +
               "}");
        }

        public Student(String nume)
        {
            this.Nume = nume;
        }

        public Student(Double averageMark)
        {
            this.averageMark = averageMark;
        }

        public Student(String nume, String grup, Double averageMark)
        {
            this.Nume = nume;
            this.grup = grup;
            this.averageMark = averageMark;

        }


    }
}