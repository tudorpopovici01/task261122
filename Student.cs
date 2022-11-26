using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentProject
{
    public class Student
    {
        private string nume;
        protected string grup;
        public double averageMark;

        
        public string Nume 
        {
            get 
            {
                return this.nume;
            }

            set 
            {
                this.nume = value;
            }
        }

        public string Grup
        {
            get
            {
                return this.grup;
            }

            set
            {
                this.nume = grup;
            }
        }

        public double AverageMark
        {
            get { return this.averageMark; }
            set { this.averageMark = value; }
        }
        public Student() 
        {
            this.nume = "Popovici Tudor";
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
            this.nume = nume;
        }

        public Student(Double averageMark)
        {
            this.averageMark = averageMark;
        }

        public Student(String nume, String grup, Double averageMark)
        {
            this.nume = nume;
            this.grup = grup;
            this.averageMark = averageMark;

        }


    }
}