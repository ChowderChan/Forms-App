using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    [Serializable]
    public class Tranzactie
    {
        private int IdTranzactie;
        private double Pret;
        private string Stare;
        private int IdTurist;

        public Tranzactie() { }

        public Tranzactie(int id, double pret, string stare, int idTurist)
        {
            IdTranzactie = id;
            Pret = pret;
            Stare = stare;
            IdTurist = idTurist;
        }

        public int ID
        {
            get { return IdTranzactie; }
            set { IdTranzactie = value; }
        }

        public double PR
        {
            get { return Pret; }
            set { Pret = value; }
        }

        public string ST
        {
            get { return Stare; }
            set { Stare = value; }
        }

        public int IDT
        {
            get { return IdTurist; }
            set { IdTurist = value; }
        }
    }
}
