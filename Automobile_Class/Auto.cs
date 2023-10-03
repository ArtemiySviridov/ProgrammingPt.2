using System;
using System.Globalization;
using Microsoft.VisualBasic;

namespace Automobile_Class
{
    public class Automobile
    {
        private string brand;
        private string model;
        private int releaseYear;
        private int diagnosticYear;
        private string owner;

        public Automobile(string brand, string model, int releaseYear, int diagnosticYear, string owner)
        {
            this.brand = brand;
            this.model = model;
            this.releaseYear = releaseYear;
            this.diagnosticYear = diagnosticYear;
            this.owner = owner;
        }

        public string Brand
        {
            get { return brand; } 
        }
        public string Model
        {
            get { return model; }
        }
        public int ReleaseYear
        {
            get { return releaseYear; }
        }
        public int DiagnosticYear
        {
            get { return diagnosticYear; }
            set { diagnosticYear = value; }
        }
        public string Owner
        {
           get { return owner; }
           set { owner = value; }
        }

        public int SumFines(params int[] fines)
        {
            int sum = 0;
            
            foreach(int fine in fines) 
            { 
                sum += fine;
            }
            return sum;
        }
        
        public string DiagnosticYearEntered(int dagyear)
        {
            string message = "";
            if (DiagnosticYear == -1)
            {
                message = "Вы не проходили ТО! Пройдите прямо сейчас.";
            }
            return message;
        }

        public bool ScrapAutomobile(int scrapped)
        {
            if (scrapped == 0) 
            {
                return false;
            }
            return true;
        }

        public int RightReleaseYear()
        {
            if (ReleaseYear < 1885 || ReleaseYear > 2023)
            {
                return 0;
            }
            return ReleaseYear;
        }

        public void WrongFineSum(int fine)
        {
            int finesum = 0;
            if (fine > 0)
            {
                finesum += fine;
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}