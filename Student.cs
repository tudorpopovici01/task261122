using System;

namespace StudentProject
{
    public class Student : Person
    {
        protected string grup;
        public double averageMark;
        private string specialitate;


        public string Grup
        {
            get
            {
                return this.grup;
            }

            set
            {
                this.grup = value;
            }
        }

        public double AverageMark
        {
            get { return this.averageMark; }
            set { this.averageMark = value; }
        }

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