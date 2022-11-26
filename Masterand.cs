namespace StudentProject
{
    class Masterand : Instruit
    {
        private string specializare;

        public string Specializare
        {
            get { return this.specializare; }
            set { this.specializare = value; }
        }

        public Masterand (string nume, string grup, double averageMark)
        {
            this.Nume = nume;
            this.Grup = grup;
            this.AverageMark = averageMark;
        }
    }
}
