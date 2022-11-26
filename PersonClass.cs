using System;

namespace StudentProject
{
    public abstract class Person
    {
        private string nume;
        private DateTime dataNast;
        private Char sex;
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

        public DateTime DataNast
        {
            get
            {
                return this.dataNast;
            }

            set
            {
                this.dataNast = value;
            }
        }

        public Char Sex
        {
            get
            {
                return this.sex;
            }

            set
            {
                this.sex = value;
            }
        }
    }
}
