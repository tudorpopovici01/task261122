using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProject
{
    public abstract class Instruit : Person
    {
        protected string grup;
        public double averageMark;

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
    }
}
